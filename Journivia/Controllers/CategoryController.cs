using Journivia.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace Journivia.Controllers
{
    public class CategoryController : Controller
    {
        private readonly Helper.Helper _helper = new Helper.Helper();
        // GET: Category
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult CategoryManagement()
        {
            // Initialize the list to hold category data
            List<CategoryBindingModel> model = new List<CategoryBindingModel>();

            // SQL connection and command
            SqlConnection connection = null;
            SqlCommand command = null;
            SqlDataReader reader = null;

            try
            {
                connection = new SqlConnection(_helper.GetConnectionPath());
                string query = "SELECT * FROM Category WHERE Active = @Active";
                command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Active", true);

                // Open connection
                connection.Open();

                // Execute reader
                reader = command.ExecuteReader();

                // Read data
                while (reader.Read())
                {
                    var category = new CategoryBindingModel();
                    category.ID = reader.GetInt32(reader.GetOrdinal("ID"));
                    category.CategoryName = reader.GetString(reader.GetOrdinal("CategoryName"));
                    category.CategoryDescription = reader.GetString(reader.GetOrdinal("CategoryDescription"));
                    category.CategoryId = !reader.IsDBNull(reader.GetOrdinal("CategoryID")) ? reader.GetInt32(reader.GetOrdinal("CategoryID")) : 0;
                    category.Active = reader.GetBoolean(reader.GetOrdinal("Active"));
                    model.Add(category);
                }
            }
            catch (Exception ex)
            {
                // Log exception (you can use a logger or store details for debugging)
                Console.WriteLine("An error occurred: " + ex.Message);
                return View("Error"); // Redirect to an error view if needed
            }
            finally
            {
                // Close and clean up resources
                if (reader != null && !reader.IsClosed)
                    reader.Close();

                if (command != null)
                    command.Dispose();

                if (connection != null && connection.State == System.Data.ConnectionState.Open)
                    connection.Close();
            }

            // Return the view with the model
            return View(model);
        }

        [HttpPost]
        public ActionResult CreateCategory(CreateCategoryModel model) 
        {
            if (ModelState.IsValid)
            {
                if(model != null)
                {
                    SqlConnection connection = new SqlConnection("");
                    string query = "INSERT INTO Category (CatrgoryName,CategoryDescription) VALUES (@Name,@Description)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Name", model.CategoryName);
                    command.Parameters.AddWithValue("@Description", model.CategoryDescription);
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                    ViewBag.Message = "Category Successfully Created.!";
                }
            }
            return View();
        }
    }
}