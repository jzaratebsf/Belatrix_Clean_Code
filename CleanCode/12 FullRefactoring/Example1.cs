using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web.UI.WebControls;

namespace Project.UserControls
{
    public class PostControl : System.Web.UI.UserControl
    {
        
        private readonly PostValidator _validator;
        private readonly PostRepository _postRepository;
        private ValidationResult results;
        private BulletedList errorSummary;

        public PostControl()
        {
            _validator = new PostValidator();
            _postRepository = new PostRepository();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {
                EvaluatePost();
            }
            else
            {
                DisplayForm();
            }
        }

        private void EvaluatePost()
        {
            Post postentity = GetPost();
            results = _validator.Validate(postentity);

            if (results.IsValid)
            {
                _postRepository.SavePost(postentity);
            }
            else
            {
                DisplayErrors();
            }
        }

        private Post GetPost()
        {
            var postentity = new Post()
            {
                // Map form fields to entity properties
                Id = Convert.ToInt32(PostId.Value),
                Title = PostTitle.Text.Trim(),
                Body = PostBody.Text.Trim()
            };
            return postentity;
        }

        private void ValidatePost()
        {
            
                       
        }

        private void DisplayErrors()
        {
            errorSummary = (BulletedList)FindControl("ErrorSummary");

            // Display errors to the user
            foreach (var failure in results.Errors)
            {
                Label errorMessage = FindControl(failure.PropertyName + "Error") as Label;

                if (errorMessage == null)
                {
                    errorSummary.Items.Add(new ListItem(failure.ErrorMessage));
                }
                else
                {
                    errorMessage.Text = failure.ErrorMessage;
                }
            }
        }

        private void DisplayForm()
        {
            // Display form
            Post postentity = _postRepository.GetPost(Convert.ToInt32(Request.QueryString["id"]));
            PostBody.Text = postentity.Body;
            PostTitle.Text = postentity.Title;
        }
              
        

        public Label PostBody { get; set; }
        public Label PostTitle { get; set; }
        public int? PostId { get; set; }
    }

    #region helpers

    public class ValidationResult
    {
        public bool IsValid { get; set; }
        public IEnumerable<ValidationError> Errors { get; set; }
    }

    public class ValidationError
    {
        public string PropertyName { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
    }

    public class PostValidator
    {
        public ValidationResult Validate(Post entity)
        {
            throw new NotImplementedException();
        }
    }

    public class DbSet<T> : IQueryable<T>
    {
        public void Add(T entity)
        {
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public Expression Expression
        {
            get { throw new NotImplementedException(); }
        }

        public Type ElementType
        {
            get { throw new NotImplementedException(); }
        }

        public IQueryProvider Provider
        {
            get { throw new NotImplementedException(); }
        }
    }

    public class PostDbContext
    {
        public DbSet<Post> Posts { get; set; }

        public void SaveChanges()
        {
        }
    }
    #endregion

}