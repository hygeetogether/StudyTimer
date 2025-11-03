namespace StudyTimerApp
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gbInput = new System.Windows.Forms.GroupBox();
            this.btnAddTask = new System.Windows.Forms.Button();
            this.numMinutes = new System.Windows.Forms.NumericUpDown();
            this.lblMinutes = new System.Windows.Forms.Label();
            this.txtTaskName = new System.Windows.Forms.TextBox();
            this.lblTask = new System.Windows.Forms.Label();
            this.gbTaskList = new System.Windows.Forms.GroupBox();
            this.btnDeleteTask = new System.Windows.Forms.Button();
            this.lvTasks = new System.Windows.Forms.ListView();
            this.colTask = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbTimer = new System.Windows.Forms.GroupBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStartPause = new System.Windows.Forms.Button();
            this.pbProgress = new System.Windows.Forms.ProgressBar();
            this.lblTimerDisplay = new System.Windows.Forms.Label();
            this.lblSelectedTask = new System.Windows.Forms.Label();
            this.timerMain = new System.Windows.Forms.Timer(this.components);
            this.gbInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMinutes)).BeginInit();
            this.gbTaskList.SuspendLayout();
            this.gbTimer.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbInput
            // 
            this.gbInput.Controls.Add(this.btnAddTask);
            this.gbInput.Controls.Add(this.numMinutes);
            this.gbInput.Controls.Add(this.lblMinutes);
            this.gbInput.Controls.Add(this.txtTaskName);
            this.gbInput.Controls.Add(this.lblTask);
            this.gbInput.Location = new System.Drawing.Point(12, 12);
            this.gbInput.Name = "gbInput";
            this.gbInput.Size = new System.Drawing.Size(560, 60);
            this.gbInput.TabIndex = 0;
            this.gbInput.TabStop = false;
            this.gbInput.Text = "새 작업 추가";
            // 
            // btnAddTask
            // 
            this.btnAddTask.Location = new System.Drawing.Point(470, 23);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(75, 23);
            this.btnAddTask.TabIndex = 4;
            this.btnAddTask.Text = "추가";
            this.btnAddTask.UseVisualStyleBackColor = true;
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
            // 
            // numMinutes
            // 
            this.numMinutes.Location = new System.Drawing.Point(340, 25);
            this.numMinutes.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.numMinutes.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMinutes.Name = "numMinutes";
            this.numMinutes.Size = new System.Drawing.Size(120, 21);
            this.numMinutes.TabIndex = 3;
            this.numMinutes.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // lblMinutes
            // 
            this.lblMinutes.AutoSize = true;
            this.lblMinutes.Location = new System.Drawing.Point(275, 28);
            this.lblMinutes.Name = "lblMinutes";
            this.lblMinutes.Size = new System.Drawing.Size(57, 12);
            this.lblMinutes.TabIndex = 2;
            this.lblMinutes.Text = "시간 (분):";
            // 
            // txtTaskName
            // 
            this.txtTaskName.Location = new System.Drawing.Point(60, 25);
            this.txtTaskName.Name = "txtTaskName";
            this.txtTaskName.Size = new System.Drawing.Size(200, 21);
            this.txtTaskName.TabIndex = 1;
            // 
            // lblTask
            // 
            this.lblTask.AutoSize = true;
            this.lblTask.Location = new System.Drawing.Point(15, 28);
            this.lblTask.Name = "lblTask";
            this.lblTask.Size = new System.Drawing.Size(37, 12);
            this.lblTask.TabIndex = 0;
            this.lblTask.Text = "할 일:";
            // 
            // gbTaskList
            // 
            this.gbTaskList.Controls.Add(this.btnDeleteTask);
            this.gbTaskList.Controls.Add(this.lvTasks);
            this.gbTaskList.Location = new System.Drawing.Point(12, 78);
            this.gbTaskList.Name = "gbTaskList";
            this.gbTaskList.Size = new System.Drawing.Size(370, 270);
            this.gbTaskList.TabIndex = 1;
            this.gbTaskList.TabStop = false;
            this.gbTaskList.Text = "작업 목록";
            // 
            // btnDeleteTask
            // 
            this.btnDeleteTask.Location = new System.Drawing.Point(280, 235);
            this.btnDeleteTask.Name = "btnDeleteTask";
            this.btnDeleteTask.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteTask.TabIndex = 1;
            this.btnDeleteTask.Text = "선택 삭제";
            this.btnDeleteTask.UseVisualStyleBackColor = true;
            this.btnDeleteTask.Click += new System.EventHandler(this.btnDeleteTask_Click);
            // 
            // lvTasks
            // 
            this.lvTasks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colTask,
            this.colTime,
            this.colStatus});
            this.lvTasks.FullRowSelect = true;
            this.lvTasks.GridLines = true;
            this.lvTasks.HideSelection = false;
            this.lvTasks.Location = new System.Drawing.Point(15, 20);
            this.lvTasks.Name = "lvTasks";
            this.lvTasks.Size = new System.Drawing.Size(340, 210);
            this.lvTasks.TabIndex = 0;
            this.lvTasks.UseCompatibleStateImageBehavior = false;
            this.lvTasks.View = System.Windows.Forms.View.Details;
            this.lvTasks.SelectedIndexChanged += new System.EventHandler(this.lvTasks_SelectedIndexChanged);
            // 
            // colTask
            // 
            this.colTask.Text = "할 일";
            this.colTask.Width = 200;
            // 
            // colTime
            // 
            this.colTime.Text = "설정 시간";
            this.colTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colTime.Width = 80;
            // 
            // colStatus
            // 
            this.colStatus.Text = "상태";
            this.colStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colStatus.Width = 80;
            // 
            // gbTimer
            // 
            this.gbTimer.Controls.Add(this.btnStop);
            this.gbTimer.Controls.Add(this.btnStartPause);
            this.gbTimer.Controls.Add(this.pbProgress);
            this.gbTimer.Controls.Add(this.lblTimerDisplay);
            this.gbTimer.Controls.Add(this.lblSelectedTask);
            this.gbTimer.Location = new System.Drawing.Point(388, 78);
            this.gbTimer.Name = "gbTimer";
            this.gbTimer.Size = new System.Drawing.Size(184, 270);
            this.gbTimer.TabIndex = 2;
            this.gbTimer.TabStop = false;
            this.gbTimer.Text = "타이머";
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(97, 235);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 4;
            this.btnStop.Text = "정지";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStartPause
            // 
            this.btnStartPause.Location = new System.Drawing.Point(16, 235);
            this.btnStartPause.Name = "btnStartPause";
            this.btnStartPause.Size = new System.Drawing.Size(75, 23);
            this.btnStartPause.TabIndex = 3;
            this.btnStartPause.Text = "시작";
            this.btnStartPause.UseVisualStyleBackColor = true;
            this.btnStartPause.Click += new System.EventHandler(this.btnStartPause_Click);
            // 
            // pbProgress
            // 
            this.pbProgress.Location = new System.Drawing.Point(16, 197);
            this.pbProgress.Name = "pbProgress";
            this.pbProgress.Size = new System.Drawing.Size(156, 23);
            this.pbProgress.Step = 1;
            this.pbProgress.TabIndex = 2;
            // 
            // lblTimerDisplay
            // 
            this.lblTimerDisplay.Font = new System.Drawing.Font("굴림", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTimerDisplay.Location = new System.Drawing.Point(6, 100);
            this.lblTimerDisplay.Name = "lblTimerDisplay";
            this.lblTimerDisplay.Size = new System.Drawing.Size(172, 37);
            this.lblTimerDisplay.TabIndex = 1;
            this.lblTimerDisplay.Text = "00:00";
            this.lblTimerDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSelectedTask
            // 
            this.lblSelectedTask.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblSelectedTask.Location = new System.Drawing.Point(6, 30);
            this.lblSelectedTask.Name = "lblSelectedTask";
            this.lblSelectedTask.Size = new System.Drawing.Size(172, 23);
            this.lblSelectedTask.TabIndex = 0;
            this.lblSelectedTask.Text = "선택된 작업: -";
            this.lblSelectedTask.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerMain
            // 
            this.timerMain.Interval = 1000;
            this.timerMain.Tick += new System.EventHandler(this.timerMain_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.gbTimer);
            this.Controls.Add(this.gbTaskList);
            this.Controls.Add(this.gbInput);
            this.Name = "Form1";
            this.Text = "스터디 + 할 일 관리 타이머";
            this.gbInput.ResumeLayout(false);
            this.gbInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMinutes)).EndInit();
            this.gbTaskList.ResumeLayout(false);
            this.gbTimer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbInput;
        private System.Windows.Forms.Button btnAddTask;
        private System.Windows.Forms.NumericUpDown numMinutes;
        private System.Windows.Forms.Label lblMinutes;
        private System.Windows.Forms.TextBox txtTaskName;
        private System.Windows.Forms.Label lblTask;
        private System.Windows.Forms.GroupBox gbTaskList;
        private System.Windows.Forms.Button btnDeleteTask;
        private System.Windows.Forms.ListView lvTasks;
        private System.Windows.Forms.ColumnHeader colTask;
        private System.Windows.Forms.ColumnHeader colTime;
        private System.Windows.Forms.ColumnHeader colStatus;
        private System.Windows.Forms.GroupBox gbTimer;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStartPause;
        private System.Windows.Forms.ProgressBar pbProgress;
        private System.Windows.Forms.Label lblTimerDisplay;
        private System.Windows.Forms.Label lblSelectedTask;
        private System.Windows.Forms.Timer timerMain;
    }
}
