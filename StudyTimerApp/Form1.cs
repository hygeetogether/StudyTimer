using System;
using System.Windows.Forms;

namespace StudyTimerApp
{
    public partial class Form1 : Form
    {
        private int remainingSeconds = 0;
        private int totalSeconds = 0;
        private ListViewItem itemToEdit = null; // 수정할 아이템을 저장하는 변수

        public Form1()
        {
            InitializeComponent();
            // MouseDoubleClick 이벤트 핸들러 추가
            this.lvTasks.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvTasks_MouseDoubleClick);
        }

        /// <summary>
        /// '추가' 또는 '수정' 버튼 클릭 시, 작업을 추가하거나 기존 작업을 수정합니다.
        /// </summary>
        private void btnAddTask_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTaskName.Text))
            {
                MessageBox.Show("할 일을 입력하세요.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 수정 모드일 경우
            if (itemToEdit != null)
            {
                itemToEdit.SubItems[0].Text = txtTaskName.Text;
                itemToEdit.SubItems[1].Text = numMinutes.Value.ToString() + "분";
                itemToEdit.Tag = (int)numMinutes.Value * 60;

                // 타이머가 대기상태였다면, 시간표시 업데이트
                if (itemToEdit.SubItems[2].Text == "대기")
                {
                    if (lvTasks.SelectedItems.Count > 0 && lvTasks.SelectedItems[0] == itemToEdit)
                    {
                        totalSeconds = (int)itemToEdit.Tag;
                        remainingSeconds = totalSeconds;
                        UpdateTimerDisplay();
                    }
                }

                itemToEdit = null; // 수정 모드 해제
                btnAddTask.Text = "추가";
            }
            // 추가 모드일 경우
            else
            {
                string[] row = { txtTaskName.Text, numMinutes.Value.ToString() + "분", "대기" };
                ListViewItem item = new ListViewItem(row);
                item.Tag = (int)numMinutes.Value * 60; // 총 시간을 초 단위로 Tag에 저장
                lvTasks.Items.Add(item);
            }

            txtTaskName.Clear();
        }

        /// <summary>
        /// 리스트뷰 항목을 더블클릭하여 수정 모드로 전환합니다.
        /// </summary>
        private void lvTasks_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lvTasks.SelectedItems.Count > 0)
            {
                // 타이머가 동작 중일 때는 수정 방지
                if (timerMain.Enabled)
                {
                    MessageBox.Show("타이머가 동작 중일 때는 수정할 수 없습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                itemToEdit = lvTasks.SelectedItems[0];
                txtTaskName.Text = itemToEdit.SubItems[0].Text;
                // "분" 글자를 제외하고 숫자만 가져오기
                string timeString = itemToEdit.SubItems[1].Text.Replace("분", "");
                if (int.TryParse(timeString, out int minutes))
                {
                    numMinutes.Value = minutes;
                }

                btnAddTask.Text = "수정";
            }
        }

        /// <summary>
        /// '선택 삭제' 버튼 클릭 시, 선택된 작업을 리스트에서 삭제합니다.
        /// </summary>
        private void btnDeleteTask_Click(object sender, EventArgs e)
        {
            if (lvTasks.SelectedItems.Count > 0)
            {
                // 수정 모드 중에 삭제될 경우
                if (itemToEdit == lvTasks.SelectedItems[0])
                {
                    itemToEdit = null;
                    btnAddTask.Text = "추가";
                    txtTaskName.Clear();
                }
                lvTasks.SelectedItems[0].Remove();
            }
        }

        /// <summary>
        /// 작업 목록에서 다른 작업을 선택했을 때 발생하는 이벤트입니다.
        /// </summary>
        private void lvTasks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (timerMain.Enabled) return; // 타이머가 동작 중일 때는 선택 변경 방지

            if (lvTasks.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lvTasks.SelectedItems[0];
                lblSelectedTask.Text = "선택된 작업: " + selectedItem.SubItems[0].Text;
                totalSeconds = (int)selectedItem.Tag;
                remainingSeconds = totalSeconds;
                UpdateTimerDisplay();
                pbProgress.Value = 0;
            }
            else
            {
                // 선택된 항목이 없을 때 초기화
                lblSelectedTask.Text = "선택된 작업: -";
                remainingSeconds = 0;
                totalSeconds = 0;
                UpdateTimerDisplay();
                pbProgress.Value = 0;
            }
        }

        /// <summary>
        /// '시작/일시정지' 버튼 클릭 시, 타이머를 시작하거나 일시정지합니다.
        /// </summary>
        private void btnStartPause_Click(object sender, EventArgs e)
        {
            if (lvTasks.SelectedItems.Count == 0)
            {
                MessageBox.Show("먼저 작업을 선택하세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (remainingSeconds <= 0) return;

            timerMain.Enabled = !timerMain.Enabled;

            if (timerMain.Enabled)
            {
                btnStartPause.Text = "일시정지";
                lvTasks.SelectedItems[0].SubItems[2].Text = "진행중";
            }
            else
            {
                btnStartPause.Text = "시작";
                lvTasks.SelectedItems[0].SubItems[2].Text = "일시정지";
            }
        }

        /// <summary>
        /// '정지' 버튼 클릭 시, 타이머를 중지하고 초기화합니다.
        /// </summary>
        private void btnStop_Click(object sender, EventArgs e)
        {
            timerMain.Enabled = false;
            btnStartPause.Text = "시작";
            if (lvTasks.SelectedItems.Count > 0)
            {
                remainingSeconds = (int)lvTasks.SelectedItems[0].Tag;
                totalSeconds = remainingSeconds;
                lvTasks.SelectedItems[0].SubItems[2].Text = "대기";
            }
            else
            {
                remainingSeconds = 0;
                totalSeconds = 0;
            }
            UpdateTimerDisplay();
            pbProgress.Value = 0;
        }

        /// <summary>
        /// 1초마다 타이머의 남은 시간을 업데이트하고 진행률을 표시합니다.
        /// </summary>
        private void timerMain_Tick(object sender, EventArgs e)
        {
            if (remainingSeconds > 0)
            {
                remainingSeconds--;
                UpdateTimerDisplay();
                pbProgress.Value = (int)(((double)(totalSeconds - remainingSeconds) / totalSeconds) * 100);
            }
            else
            {
                timerMain.Enabled = false;
                btnStartPause.Text = "시작";
                pbProgress.Value = 100;
                if (lvTasks.SelectedItems.Count > 0)
                {
                    lvTasks.SelectedItems[0].SubItems[2].Text = "완료";
                    MessageBox.Show("'" + lvTasks.SelectedItems[0].SubItems[0].Text + "' 작업 완료!", "타이머 완료", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // 타이머가 완료되면 선택된 항목의 시간으로 리셋
                    remainingSeconds = (int)lvTasks.SelectedItems[0].Tag;
                    UpdateTimerDisplay();
                    pbProgress.Value = 0;
                }
            }
        }

        /// <summary>
        /// 타이머 디스플레이 레이블의 텍스트를 업데이트합니다.
        /// </summary>
        private void UpdateTimerDisplay()
        {
            TimeSpan time = TimeSpan.FromSeconds(remainingSeconds);
            lblTimerDisplay.Text = string.Format("{0:D2}:{1:D2}", time.Minutes, time.Seconds);
        }
    }
}
