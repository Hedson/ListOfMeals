namespace c_Database_Programming
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method frror Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cookbookDataSet = new c_Database_Programming.cookbookDataSet();
            this.ingredientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ingredientTableAdapter = new c_Database_Programming.cookbookDataSetTableAdapters.IngredientTableAdapter();
            this.tableAdapterManager = new c_Database_Programming.cookbookDataSetTableAdapters.TableAdapterManager();
            this.lblRecipes = new System.Windows.Forms.Label();
            this.listOfRecipes = new System.Windows.Forms.ListBox();
            this.ingredientTableAdapter1 = new c_Database_Programming.cookbookDataSetTableAdapters.IngredientTableAdapter();
            this.listOfIngredients = new System.Windows.Forms.ListBox();
            this.lblIngredients = new System.Windows.Forms.Label();
            this.buttonAddRecipe = new System.Windows.Forms.Button();
            this.textBoxAddRecipe = new System.Windows.Forms.TextBox();
            this.textBoxAddIngredient = new System.Windows.Forms.TextBox();
            this.buttonUpdateRecipe = new System.Windows.Forms.Button();
            this.listOfAllIngredients = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAddIngredient = new System.Windows.Forms.Button();
            this.buttonRemoveIngredient = new System.Windows.Forms.Button();
            this.buttonDeleteRecipe = new System.Windows.Forms.Button();
            this.buttonAddIngredientToList = new System.Windows.Forms.Button();
            this.buttonRemoveItl = new System.Windows.Forms.Button();
            this.buttonDeleteFromAllRecipes = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonGoToIngredientsTable = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cookbookDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cookbookDataSet
            // 
            this.cookbookDataSet.DataSetName = "cookbookDataSet";
            this.cookbookDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ingredientBindingSource
            // 
            this.ingredientBindingSource.DataMember = "Ingredient";
            this.ingredientBindingSource.DataSource = this.cookbookDataSet;
            // 
            // ingredientTableAdapter
            // 
            this.ingredientTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.IngredientTableAdapter = this.ingredientTableAdapter;
            this.tableAdapterManager.RecipeIngredientTableAdapter = null;
            this.tableAdapterManager.RecipeTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = c_Database_Programming.cookbookDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // lblRecipes
            // 
            this.lblRecipes.AutoSize = true;
            this.lblRecipes.Location = new System.Drawing.Point(32, 120);
            this.lblRecipes.Name = "lblRecipes";
            this.lblRecipes.Size = new System.Drawing.Size(64, 13);
            this.lblRecipes.TabIndex = 1;
            this.lblRecipes.Text = "Recipes list:";
            // 
            // listOfRecipes
            // 
            this.listOfRecipes.BackColor = System.Drawing.SystemColors.Window;
            this.listOfRecipes.FormattingEnabled = true;
            this.listOfRecipes.Location = new System.Drawing.Point(35, 136);
            this.listOfRecipes.Name = "listOfRecipes";
            this.listOfRecipes.Size = new System.Drawing.Size(149, 329);
            this.listOfRecipes.TabIndex = 2;
            this.listOfRecipes.SelectedIndexChanged += new System.EventHandler(this.listOfRecipes_SelectedIndexChanged);
            // 
            // ingredientTableAdapter1
            // 
            this.ingredientTableAdapter1.ClearBeforeFill = true;
            // 
            // listOfIngredients
            // 
            this.listOfIngredients.FormattingEnabled = true;
            this.listOfIngredients.Location = new System.Drawing.Point(213, 138);
            this.listOfIngredients.Name = "listOfIngredients";
            this.listOfIngredients.Size = new System.Drawing.Size(149, 329);
            this.listOfIngredients.TabIndex = 4;
            // 
            // lblIngredients
            // 
            this.lblIngredients.AutoSize = true;
            this.lblIngredients.Location = new System.Drawing.Point(210, 120);
            this.lblIngredients.Name = "lblIngredients";
            this.lblIngredients.Size = new System.Drawing.Size(138, 13);
            this.lblIngredients.TabIndex = 3;
            this.lblIngredients.Text = "Selected recipe ingredients:";
            // 
            // buttonAddRecipe
            // 
            this.buttonAddRecipe.Location = new System.Drawing.Point(35, 52);
            this.buttonAddRecipe.Name = "buttonAddRecipe";
            this.buttonAddRecipe.Size = new System.Drawing.Size(75, 23);
            this.buttonAddRecipe.TabIndex = 5;
            this.buttonAddRecipe.Text = "Add Recipe";
            this.buttonAddRecipe.UseVisualStyleBackColor = true;
            this.buttonAddRecipe.Click += new System.EventHandler(this.bAddRecipe_Click);
            // 
            // textBoxAddRecipe
            // 
            this.textBoxAddRecipe.Location = new System.Drawing.Point(35, 26);
            this.textBoxAddRecipe.Name = "textBoxAddRecipe";
            this.textBoxAddRecipe.Size = new System.Drawing.Size(163, 20);
            this.textBoxAddRecipe.TabIndex = 6;
            // 
            // textBoxAddIngredient
            // 
            this.textBoxAddIngredient.Location = new System.Drawing.Point(411, 26);
            this.textBoxAddIngredient.Name = "textBoxAddIngredient";
            this.textBoxAddIngredient.Size = new System.Drawing.Size(138, 20);
            this.textBoxAddIngredient.TabIndex = 8;
            // 
            // buttonUpdateRecipe
            // 
            this.buttonUpdateRecipe.Location = new System.Drawing.Point(116, 52);
            this.buttonUpdateRecipe.Name = "buttonUpdateRecipe";
            this.buttonUpdateRecipe.Size = new System.Drawing.Size(82, 23);
            this.buttonUpdateRecipe.TabIndex = 7;
            this.buttonUpdateRecipe.Text = "Update Name";
            this.buttonUpdateRecipe.UseVisualStyleBackColor = true;
            this.buttonUpdateRecipe.Click += new System.EventHandler(this.bUpRecipe_Click);
            // 
            // listOfAllIngredients
            // 
            this.listOfAllIngredients.FormattingEnabled = true;
            this.listOfAllIngredients.Location = new System.Drawing.Point(411, 127);
            this.listOfAllIngredients.Name = "listOfAllIngredients";
            this.listOfAllIngredients.Size = new System.Drawing.Size(138, 251);
            this.listOfAllIngredients.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(425, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "List of all ingredients";
            // 
            // buttonAddIngredient
            // 
            this.buttonAddIngredient.Location = new System.Drawing.Point(570, 136);
            this.buttonAddIngredient.Name = "buttonAddIngredient";
            this.buttonAddIngredient.Size = new System.Drawing.Size(114, 39);
            this.buttonAddIngredient.TabIndex = 11;
            this.buttonAddIngredient.Text = "Add Ingredient to selected recipe";
            this.buttonAddIngredient.UseVisualStyleBackColor = true;
            this.buttonAddIngredient.Click += new System.EventHandler(this.bAddIngredient_Click);
            // 
            // buttonRemoveIngredient
            // 
            this.buttonRemoveIngredient.Location = new System.Drawing.Point(570, 183);
            this.buttonRemoveIngredient.Name = "buttonRemoveIngredient";
            this.buttonRemoveIngredient.Size = new System.Drawing.Size(114, 41);
            this.buttonRemoveIngredient.TabIndex = 12;
            this.buttonRemoveIngredient.Text = "Remove Ingredient from selected recipe";
            this.buttonRemoveIngredient.UseVisualStyleBackColor = true;
            this.buttonRemoveIngredient.Click += new System.EventHandler(this.bRemoveIngredient_Click);
            // 
            // buttonDeleteRecipe
            // 
            this.buttonDeleteRecipe.Location = new System.Drawing.Point(35, 81);
            this.buttonDeleteRecipe.Name = "buttonDeleteRecipe";
            this.buttonDeleteRecipe.Size = new System.Drawing.Size(163, 23);
            this.buttonDeleteRecipe.TabIndex = 13;
            this.buttonDeleteRecipe.Text = "Delete Recipe";
            this.buttonDeleteRecipe.UseVisualStyleBackColor = true;
            this.buttonDeleteRecipe.Click += new System.EventHandler(this.bDeleteRecipe_Click);
            // 
            // buttonAddIngredientToList
            // 
            this.buttonAddIngredientToList.Location = new System.Drawing.Point(411, 52);
            this.buttonAddIngredientToList.Name = "buttonAddIngredientToList";
            this.buttonAddIngredientToList.Size = new System.Drawing.Size(138, 44);
            this.buttonAddIngredientToList.TabIndex = 14;
            this.buttonAddIngredientToList.Text = "Add Ingredient\r\n to Ingredient list";
            this.buttonAddIngredientToList.UseVisualStyleBackColor = true;
            this.buttonAddIngredientToList.Click += new System.EventHandler(this.bAddItI_Click);
            // 
            // buttonRemoveItl
            // 
            this.buttonRemoveItl.Location = new System.Drawing.Point(570, 314);
            this.buttonRemoveItl.Name = "buttonRemoveItl";
            this.buttonRemoveItl.Size = new System.Drawing.Size(114, 49);
            this.buttonRemoveItl.TabIndex = 16;
            this.buttonRemoveItl.Text = "Delete ingredient from all recipes and ingredient database.";
            this.buttonRemoveItl.UseVisualStyleBackColor = true;
            this.buttonRemoveItl.Click += new System.EventHandler(this.RemoveItl_Click);
            // 
            // buttonDeleteFromAllRecipes
            // 
            this.buttonDeleteFromAllRecipes.Location = new System.Drawing.Point(570, 266);
            this.buttonDeleteFromAllRecipes.Name = "buttonDeleteFromAllRecipes";
            this.buttonDeleteFromAllRecipes.Size = new System.Drawing.Size(114, 42);
            this.buttonDeleteFromAllRecipes.TabIndex = 17;
            this.buttonDeleteFromAllRecipes.Text = "Delete ingredient from all recipes\r\n";
            this.buttonDeleteFromAllRecipes.UseVisualStyleBackColor = true;
            this.buttonDeleteFromAllRecipes.Click += new System.EventHandler(this.deleteFromAllRecipes_Click_1);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(615, 406);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(69, 61);
            this.buttonExit.TabIndex = 18;
            this.buttonExit.Text = "EXIT";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.bExit_Click);
            // 
            // buttonGoToIngredientsTable
            // 
            this.buttonGoToIngredientsTable.Location = new System.Drawing.Point(411, 400);
            this.buttonGoToIngredientsTable.Name = "buttonGoToIngredientsTable";
            this.buttonGoToIngredientsTable.Size = new System.Drawing.Size(138, 67);
            this.buttonGoToIngredientsTable.TabIndex = 19;
            this.buttonGoToIngredientsTable.Text = "Ingredients Table";
            this.buttonGoToIngredientsTable.UseVisualStyleBackColor = true;
            this.buttonGoToIngredientsTable.Click += new System.EventHandler(this.bGoToIngredientsTable_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(713, 499);
            this.Controls.Add(this.buttonGoToIngredientsTable);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonDeleteFromAllRecipes);
            this.Controls.Add(this.buttonRemoveItl);
            this.Controls.Add(this.buttonAddIngredientToList);
            this.Controls.Add(this.buttonDeleteRecipe);
            this.Controls.Add(this.buttonRemoveIngredient);
            this.Controls.Add(this.buttonAddIngredient);
            this.Controls.Add(this.listOfAllIngredients);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxAddIngredient);
            this.Controls.Add(this.buttonUpdateRecipe);
            this.Controls.Add(this.textBoxAddRecipe);
            this.Controls.Add(this.buttonAddRecipe);
            this.Controls.Add(this.listOfIngredients);
            this.Controls.Add(this.lblIngredients);
            this.Controls.Add(this.listOfRecipes);
            this.Controls.Add(this.lblRecipes);
            this.Name = "FormMain";
            this.Text = "List of Meals";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cookbookDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private cookbookDataSet cookbookDataSet;
        private System.Windows.Forms.BindingSource ingredientBindingSource;
        private cookbookDataSetTableAdapters.IngredientTableAdapter ingredientTableAdapter;
        private cookbookDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label lblRecipes;
        private System.Windows.Forms.ListBox listOfRecipes;
        private cookbookDataSetTableAdapters.IngredientTableAdapter ingredientTableAdapter1;
        private System.Windows.Forms.ListBox listOfIngredients;
        private System.Windows.Forms.Label lblIngredients;
        private System.Windows.Forms.Button buttonAddRecipe;
        private System.Windows.Forms.TextBox textBoxAddRecipe;
        private System.Windows.Forms.TextBox textBoxAddIngredient;
        private System.Windows.Forms.Button buttonUpdateRecipe;
        private System.Windows.Forms.ListBox listOfAllIngredients;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAddIngredient;
        private System.Windows.Forms.Button buttonRemoveIngredient;
        private System.Windows.Forms.Button buttonDeleteRecipe;
        private System.Windows.Forms.Button buttonAddIngredientToList;
        private System.Windows.Forms.Button buttonRemoveItl;
        private System.Windows.Forms.Button buttonDeleteFromAllRecipes;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonGoToIngredientsTable;
    }
}

