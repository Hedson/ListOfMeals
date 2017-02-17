using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace c_Database_Programming
{
    public partial class FormMain : Form
    {
        SqlConnection connection;
        string connectionString;

        public FormMain()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["c_Database_Programming.Properties.Settings.cookbookConnectionString"].ConnectionString;
        }

        private void ingredientBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ingredientBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cookbookDataSet);

        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cookbookDataSet.Ingredient' table. You can move, or remove it, as needed.
            this.ingredientTableAdapter.Fill(this.cookbookDataSet.Ingredient);
            PopulateRecipes();
            PopulateAllIngredients();

        }
        private void PopulateRecipes()
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Recipe", connection))
            {
                DataTable recipeTable = new DataTable();
                adapter.Fill(recipeTable);

                listOfRecipes.DisplayMember = "Name";
                listOfRecipes.ValueMember = "Id";
                listOfRecipes.DataSource = recipeTable;
            }
        }


        private void PopulateIngredients()
        {
            string query = "SELECT a.Name FROM Ingredient a " +
                "INNER JOIN RecipeIngredient b ON a.Id = b.IngredientId " +
                "WHERE b.RecipeId = @RecipeId";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.Parameters.AddWithValue("@RecipeId", listOfRecipes.SelectedValue);

                DataTable ingredientTable = new DataTable();
                adapter.Fill(ingredientTable);

                listOfIngredients.DisplayMember = "Name";
                listOfIngredients.ValueMember = "Id";
                listOfIngredients.DataSource = ingredientTable;
            }
        }


        private void PopulateAllIngredients()
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Ingredient", connection))
            {
                DataTable ingredientTable = new DataTable();
                adapter.Fill(ingredientTable);

                listOfAllIngredients.DisplayMember = "Name";
                listOfAllIngredients.ValueMember = "Id";
                listOfAllIngredients.DataSource = ingredientTable;
            }
        }

        private void listOfRecipes_SelectedIndexChanged(object sender, EventArgs e)
        {
            // MessageBox.Show(listOfRecipes.SelectedValue.ToString());
            PopulateIngredients();
        }

        /*Button Add Recipe Click event:*/
        private void bAddRecipe_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO Recipe VALUES (@RecipeName, 88, 'bla bla')";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@RecipeName", textBoxAddRecipe.Text);


                command.ExecuteScalar();
            }

            PopulateRecipes();
        }

        private void bUpRecipe_Click(object sender, EventArgs e)
        {
            string query = "UPDATE Recipe SET Name = @RecipeName WHERE Id = @RecipeId";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@RecipeName", textBoxAddRecipe.Text);
                command.Parameters.AddWithValue("@RecipeId", listOfRecipes.SelectedValue);

                command.ExecuteScalar();
            }

            PopulateRecipes();
        }

        private void bAddIngredient_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO RecipeIngredient VALUES (@RecipeId,@IngredientId)";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@RecipeId", listOfRecipes.SelectedValue);
                command.Parameters.AddWithValue("@IngredientId", listOfAllIngredients.SelectedValue);

                command.ExecuteScalar();
            }
            PopulateIngredients();
        }


        //iiii
        private void bDeleteRecipe_Click(object sender, EventArgs e) //Delete Recipe element buttonclick event
        {
            string query = "DELETE from RecipeIngredient where RecipeId=@RecipeId";
            //DELETE from Recipe where id=@RecipeId
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                //command.Parameters.AddWithValue("@RecipeName", tAddRecipe.Text);
                command.Parameters.AddWithValue("@RecipeId", listOfRecipes.SelectedValue);

                command.ExecuteScalar();
            }


            query = "DELETE from Recipe where id=@RecipeId";
            //DELETE from Recipe where id=@RecipeId
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                //command.Parameters.AddWithValue("@RecipeName", tAddRecipe.Text);
                command.Parameters.AddWithValue("@RecipeId", listOfRecipes.SelectedValue);

                command.ExecuteScalar();
            }

            PopulateRecipes();
            PopulateRecipes();
        }

        private void bRemoveIngredient_Click(object sender, EventArgs e) //delete selected ingredient from selecter Recipe
        {
            string query = "DELETE FROM RecipeIngredient WHERE RecipeId=@RecipeId AND IngredientId=@IngredientId";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@RecipeId", listOfRecipes.SelectedValue);
                command.Parameters.AddWithValue("@IngredientId", listOfAllIngredients.SelectedValue);

                command.ExecuteScalar();
            }
            PopulateIngredients();
        }

        private void bAddItI_Click(object sender, EventArgs e)  //Add indegrient Name wrote in textfield to Indegrients list
        {
            string query = "INSERT INTO Ingredient VALUES (@IngredientName)";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@IngredientName", textBoxAddIngredient.Text);


                command.ExecuteScalar();
            }

            PopulateAllIngredients();
        }

        





        private void RemoveItl_Click(object sender, EventArgs e)
        {
            deleteFromAllRecipesMethod(sender,e);   // Method that delete Ingredient from all recipes before delete recipe from Database.

            string query1 = "DELETE FROM Ingredient WHERE Id=@IngredientId";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query1, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@IngredientId", listOfAllIngredients.SelectedValue);

                command.ExecuteScalar();

            }

            PopulateAllIngredients();
        }

        private void deleteFromAllRecipes_Click_1(object sender, EventArgs e)
        {
            string query = "DELETE FROM RecipeIngredient WHERE IngredientId=@IngredientId";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@IngredientId", listOfAllIngredients.SelectedValue);

                command.ExecuteScalar();
            }
            PopulateIngredients();
        }

        private void bExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bGoToIngredientsTable_Click(object sender, EventArgs e)
        {
            DataBase ingredients = new DataBase();
            ingredients.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void deleteFromAllRecipesMethod(object sender, EventArgs e)
        {
            string query = "DELETE FROM RecipeIngredient WHERE IngredientId=@IngredientId";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@IngredientId", listOfAllIngredients.SelectedValue);

                command.ExecuteScalar();
            }
            PopulateIngredients();
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    Form2 m = new Form2();
        //    m.Show();

        //    this.Hide();
        //}

        //private void bExit_Click(object sender, EventArgs e)
        //{
        //    Application.Exit();
        //}

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    Form1 m = new Form1();
        //    m.Show();

        //    this.Hide();
        //}
    }
}
