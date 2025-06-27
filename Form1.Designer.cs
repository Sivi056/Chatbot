using System;
using System.Windows.Forms;

namespace Chatbot
{
    public partial class Form1 : Form
    {
        private Chatbot chatbot; // Instance of the Chatbot class
        private int quizScore = 0;
        private int questionCount = 0;

        // The error CS0111 indicates that there are multiple constructors with the same signature in the 'Form1' class.
        // To fix this, ensure there is only one constructor with the same parameter types.

     

        private void InitializeComponent()
        {
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.btnSend = new System.Windows.Forms.Button();
            this.lstResponses = new System.Windows.Forms.ListBox();
            this.btnAddTask = new System.Windows.Forms.Button();
            this.btnStartQuiz = new System.Windows.Forms.Button();
            this.btnShowLog = new System.Windows.Forms.Button();
            this.btnFunFact = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button(); // Back button
            this.txtUserInput = new System.Windows.Forms.TextBox();
            this.txtTaskTitle = new System.Windows.Forms.TextBox();
            this.txtTaskDescription = new System.Windows.Forms.TextBox();
            this.dtpReminder = new System.Windows.Forms.DateTimePicker();
            this.btnExit = new System.Windows.Forms.Button(); // Exit button
            this.lblUserInput = new System.Windows.Forms.Label(); // Label for user input
            this.lblTaskTitle = new System.Windows.Forms.Label(); // Label for task title
            this.lblTaskDescription = new System.Windows.Forms.Label(); // Label for task description
            this.SuspendLayout();

            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(0, 0);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(21, 100);
            this.vScrollBar1.TabIndex = 13;

            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.White;
            this.btnSend.ForeColor = System.Drawing.Color.Black;
            this.btnSend.Location = new System.Drawing.Point(36, 78);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 1;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);

            // 
            // lstResponses
            // 
            this.lstResponses.BackColor = System.Drawing.Color.LightGray;
            this.lstResponses.ForeColor = System.Drawing.Color.Black;
            this.lstResponses.FormattingEnabled = true;
            this.lstResponses.ItemHeight = 16;
            this.lstResponses.Location = new System.Drawing.Point(36, 288);
            this.lstResponses.Name = "lstResponses";
            this.lstResponses.Size = new System.Drawing.Size(1144, 292);
            this.lstResponses.TabIndex = 12;

            // 
            // btnAddTask
            // 
            this.btnAddTask.BackColor = System.Drawing.Color.White;
            this.btnAddTask.ForeColor = System.Drawing.Color.Black;
            this.btnAddTask.Location = new System.Drawing.Point(36, 243);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(75, 23);
            this.btnAddTask.TabIndex = 3;
            this.btnAddTask.Text = "Add Task";
            this.btnAddTask.UseVisualStyleBackColor = true;
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);

            // 
            // btnStartQuiz
            // 
            this.btnStartQuiz.BackColor = System.Drawing.Color.White;
            this.btnStartQuiz.ForeColor = System.Drawing.Color.Black;
            this.btnStartQuiz.Location = new System.Drawing.Point(542, 50);
            this.btnStartQuiz.Name = "btnStartQuiz";
            this.btnStartQuiz.Size = new System.Drawing.Size(95, 30);
            this.btnStartQuiz.TabIndex = 5;
            this.btnStartQuiz.Text = "Start Quiz";
            this.btnStartQuiz.UseVisualStyleBackColor = true;
            this.btnStartQuiz.Click += new System.EventHandler(this.btnStartQuiz_Click);

            // 
            // btnShowLog
            // 
            this.btnShowLog.BackColor = System.Drawing.Color.White;
            this.btnShowLog.ForeColor = System.Drawing.Color.Black;
            this.btnShowLog.Location = new System.Drawing.Point(773, 50);
            this.btnShowLog.Name = "btnShowLog";
            this.btnShowLog.Size = new System.Drawing.Size(330, 30);
            this.btnShowLog.TabIndex = 4;
            this.btnShowLog.Text = "Show Activity Log";
            this.btnShowLog.UseVisualStyleBackColor = true;
            this.btnShowLog.Click += new System.EventHandler(this.btnShowLog_Click);

            // 
            // btnFunFact
            // 
            this.btnFunFact.BackColor = System.Drawing.Color.White;
            this.btnFunFact.ForeColor = System.Drawing.Color.Black;
            this.btnFunFact.Location = new System.Drawing.Point(655, 50);
            this.btnFunFact.Name = "btnFunFact";
            this.btnFunFact.Size = new System.Drawing.Size(95, 30);
            this.btnFunFact.TabIndex = 10;
            this.btnFunFact.Text = "Fun Facts";
            this.btnFunFact.UseVisualStyleBackColor = true;
            this.btnFunFact.Click += new System.EventHandler(this.btnFunFact_Click);

            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Gray; // Style the back button
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(150, 78);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 15;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);

            // 
            // txtUserInput
            // 
            this.txtUserInput.BackColor = System.Drawing.Color.White;
            this.txtUserInput.ForeColor = System.Drawing.Color.Black;
            this.txtUserInput.Location = new System.Drawing.Point(36, 50);
            this.txtUserInput.Name = "txtUserInput";
            this.txtUserInput.Size = new System.Drawing.Size(304, 22);
            this.txtUserInput.TabIndex = 6;

            // 
            // txtTaskTitle
            // 
            this.txtTaskTitle.BackColor = System.Drawing.Color.White;
            this.txtTaskTitle.ForeColor = System.Drawing.Color.Black;
            this.txtTaskTitle.Location = new System.Drawing.Point(36, 159);
            this.txtTaskTitle.Name = "txtTaskTitle";
            this.txtTaskTitle.Size = new System.Drawing.Size(272, 22);
            this.txtTaskTitle.TabIndex = 7;

            // 
            // txtTaskDescription
            // 
            this.txtTaskDescription.BackColor = System.Drawing.Color.White;
            this.txtTaskDescription.ForeColor = System.Drawing.Color.Black;
            this.txtTaskDescription.Location = new System.Drawing.Point(359, 159);
            this.txtTaskDescription.Name = "txtTaskDescription";
            this.txtTaskDescription.Size = new System.Drawing.Size(278, 22);
            this.txtTaskDescription.TabIndex = 8;

            // 
            // dtpReminder
            // 
            this.dtpReminder.Location = new System.Drawing.Point(36, 215);
            this.dtpReminder.Name = "dtpReminder";
            this.dtpReminder.Size = new System.Drawing.Size(272, 22);
            this.dtpReminder.TabIndex = 11;

            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(36, 600);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);

            // 
            // lblUserInput
            // 
            this.lblUserInput.AutoSize = true;
            this.lblUserInput.Location = new System.Drawing.Point(36, 30);
            this.lblUserInput.Name = "lblUserInput";
            this.lblUserInput.Size = new System.Drawing.Size(124, 16);
            this.lblUserInput.TabIndex = 15;
            this.lblUserInput.Text = "Enter your question:";

            // 
            // lblTaskTitle
            // 
            this.lblTaskTitle.AutoSize = true;
            this.lblTaskTitle.Location = new System.Drawing.Point(36, 139);
            this.lblTaskTitle.Name = "lblTaskTitle";
            this.lblTaskTitle.Size = new System.Drawing.Size(92, 16);
            this.lblTaskTitle.TabIndex = 16;
            this.lblTaskTitle.Text = "Enter task title:";

            // 
            // lblTaskDescription
            // 
            this.lblTaskDescription.AutoSize = true;
            this.lblTaskDescription.Location = new System.Drawing.Point(356, 139);
            this.lblTaskDescription.Name = "lblTaskDescription";
            this.lblTaskDescription.Size = new System.Drawing.Size(138, 16);
            this.lblTaskDescription.TabIndex = 17;
            this.lblTaskDescription.Text = "Enter task description:";

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1212, 624);
            this.Controls.Add(this.btnFunFact);
            this.Controls.Add(this.dtpReminder);
            this.Controls.Add(this.txtTaskDescription);
            this.Controls.Add(this.txtTaskTitle);
            this.Controls.Add(this.txtUserInput);
            this.Controls.Add(this.btnShowLog);
            this.Controls.Add(this.btnStartQuiz);
            this.Controls.Add(this.btnAddTask);
            this.Controls.Add(this.lstResponses);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblUserInput);
            this.Controls.Add(this.lblTaskTitle);
            this.Controls.Add(this.lblTaskDescription);
            this.Name = "Form1";
            this.Text = "Cybersecurity Awareness Chatbot";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #region Controls
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.ListBox lstResponses;
        private System.Windows.Forms.Button btnAddTask;
        private System.Windows.Forms.Button btnStartQuiz;
        private System.Windows.Forms.Button btnShowLog;
        private System.Windows.Forms.Button btnFunFact;
        private System.Windows.Forms.Button btnBack; // Declare the back button
        private System.Windows.Forms.TextBox txtUserInput;
        private System.Windows.Forms.TextBox txtTaskTitle;
        private System.Windows.Forms.TextBox txtTaskDescription;
        private System.Windows.Forms.DateTimePicker dtpReminder;
        private System.Windows.Forms.Button btnExit; // Declare the exit button
        private System.Windows.Forms.Label lblUserInput; // Label for user input
        private System.Windows.Forms.Label lblTaskTitle; // Label for task title
        private System.Windows.Forms.Label lblTaskDescription; // Label for task description
        #endregion

        // Button click event for Fun Fact
        private void btnFunFact_Click(object sender, EventArgs e)
        {
            string funFact = chatbot.GetFunFact();
            lstResponses.Items.Add($"Fun Fact: {funFact}");
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string userInput = txtUserInput.Text.Trim();
            lstResponses.Items.Add($"You: {userInput}");

            string response = chatbot.GetResponse(userInput); // Get response from the chatbot
            lstResponses.Items.Add($"Bot: {response}");

            txtUserInput.Clear();
            txtUserInput.Focus();
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            string title = txtTaskTitle.Text;
            string description = txtTaskDescription.Text;
            lstResponses.Items.Add($"Task Added: {title} - {description}");
            txtTaskTitle.Clear();
            txtTaskDescription.Clear();
        }

        private void btnStartQuiz_Click(object sender, EventArgs e)
        {
            StartQuiz();
        }

        private void btnShowLog_Click(object sender, EventArgs e)
        {
            lstResponses.Items.Clear(); // Clear existing responses
            lstResponses.Items.Add("Showing activity log...");
            // Here you can display actual log entries if you have a log mechanism
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            lstResponses.Items.Clear(); // Clear responses when going back
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close(); // Close the application
        }

        private void StartQuiz()
        {
            quizScore = 0;
            questionCount = 0;
            lstResponses.Items.Clear();
            AskQuestion();
        }

        private void AskQuestion()
        {
            if (questionCount < 5)
            {
                var question = chatbot.GetQuizQuestion();
                lstResponses.Items.Add($"Question: {question.Question}");
                txtUserInput.Tag = question.Answer; // Store the answer in the Tag property
                txtUserInput.Text = ""; // Clear the input box for the answer
                questionCount++;
            }
            else
            {
                EndQuiz();
            }
        }

        private void EndQuiz()
        {
            lstResponses.Items.Add($"Quiz ended! Your score: {quizScore}/5");
            txtUserInput.Text = ""; // Clear the input box
            txtUserInput.Tag = null;
        }
    }
}