using System;
using System.ComponentModel;
using System.Windows.Forms;
using static DLS.CONSTANTS;

namespace DLS
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private string Current_Course_Title = BASIC_STR;
        private int mode = 0;

        private void RefreshList()
        {
            DLSdata DLSdata = GenericXmlSerializer.ReadObject<DLSdata>("DLSdata.xml");
            listBox.Items.Clear();

            switch (mode)
            {
                case 1:
                    lblTitle.Text = "ЭЛЕКТРОННЫЕ КУРСЫ";
                    butOpen.Show();
                    butOpen.Text = "Открыть курс";

                    if (DLSdata.User.role == "преподаватель")
                    {
                        butAdd.Show();
                        butDelete.Show();
                        butEdit.Show();
                        butAdd.Text = "Добавить курс";
                        butDelete.Text = "Удалить курс";
                        butEdit.Text = "Изменить курс";
                    }

                    foreach (Course cs in DLSdata.Course_List)
                    {
                        cs.Calc_Value();
                        listBox.Items.Add($"|{cs.title}|   Автор: {cs.author}  |  ~{cs.total_value} мин");
                    }
                    break;

                case 2:
                    lblTitle.Text = Current_Course_Title;
                    butOpen.Show();
                    butOpen.Text = "Открыть форму";

                    if (DLSdata.User.role == "преподаватель")
                    {
                        butAdd.Show();
                        butDelete.Show();
                        butEdit.Show();                      
                        butAdd.Text = "Добавить форму";
                        butDelete.Text = "Удалить форму";
                        butEdit.Text = "Изменить форму";
                    }

                    try
                    {
                        foreach (Method m in DLSdata.Find_Course(Current_Course_Title).method_list)
                        {
                            m.Calc_val();
                            listBox.Items.Add($"|{m.title}|   {m.type}   | {m.value} мин");
                        }
                    }
                    catch { return; }

                    break;

                default:
                    butAdd.Hide();
                    butDelete.Hide();
                    butEdit.Hide();
                    butOpen.Hide();
                    return;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mode = 0;
            RefreshList();
            listBox.Items.Add("Добро пожаловать в систему дистанционного обучения");
            lblTitle.Text = "ПРИВЕТСТВИЕ";            
        }

        private void butCabinet_Click(object sender, EventArgs e)
        {
            DLSdata DLSdata = GenericXmlSerializer.ReadObject<DLSdata>("DLSdata.xml");

            mode = 0;
            RefreshList();
            lblTitle.Text = "ЛИЧНЫЙ КАБИНЕТ ПОЛЬЗОВАТЕЛЯ";

            listBox.Items.Add($"Имя: {DLSdata.User.name} - {DLSdata.User.role}");         

            listBox.Items.Add($"логин: {DLSdata.User.login}");
            listBox.Items.Add($"пароль: {DLSdata.User.password}");
            listBox.Items.Add("-----------------------------------------------------------------------");
            if (DLSdata.User.role == "преподаватель")
            {
                teacher tc = (teacher)DLSdata.User;
                listBox.Items.Add($"Предмет: {tc.subject}");
            }
            double sum = 0;

            foreach (Course cs in DLSdata.Course_List)
            {
                cs.Calc_Value();
                if (cs.author == DLSdata.User.name)
                    sum += cs.total_value;
            }

            listBox.Items.Add($"Общее расчетное время изучения всех курсов пользователя: {sum} мин");
            if (sum < RECOMMENDED_TIME)
                listBox.Items.Add($"Рекомендуется добавить материал как минимум на {RECOMMENDED_TIME - sum} мин");
            else
                listBox.Items.Add("Норма учебного времени выполнена");
        }

        private void butCourses_Click(object sender, EventArgs e)
        {
            mode = 1;
            RefreshList();
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedString = BASIC_STR;
            try
            {
                selectedString = listBox.SelectedItem.ToString();
            }
            catch (Exception ex)
            {
                listBox.ClearSelected();
            }

            if (selectedString[0] != '|')
                listBox.ClearSelected();
        }

        private void butAdd_Click(object sender, EventArgs e)
        {
            DLSdata DLSdata = GenericXmlSerializer.ReadObject<DLSdata>("DLSdata.xml");
            Form frm;

            switch (mode)
            {
                case 1:
                    frm = new AddCourseForm();
                    frm.ShowDialog();
                    if (DataTransferObject.course != null)
                    {
                        DLSdata.Course_List.Add(DataTransferObject.course);
                        DataTransferObject.course = null;
                        GenericXmlSerializer.WriteObject(DLSdata, "DLSdata.xml");
                        RefreshList();
                    }                       
                    break;

                case 2:
                    int course_ind = DLSdata.Find_Course_ind(Current_Course_Title);
                    if (course_ind == -1)
                        return;

                    frm = new AddMethodForm();
                    frm.ShowDialog();

                    if (DataTransferObject.str != BASIC_STR)
                    {
                        string type = DataTransferObject.str;

                        switch (type)
                        {
                            case "Параграф":
                                frm = new TextMethod();                                  
                                break;

                            case "Изображение":
                                frm = new PictureMethod();
                                break;

                            case "Видеоролик":
                                frm = new VideoMethod();
                                break;

                            case "Тест":
                                frm = new EditTestMethod();
                                break;

                            default:
                                return;
                        }

                        frm.ShowDialog();

                        if (DataTransferObject.method != null)
                        {
                            DataTransferObject.method.Calc_val();
                            DLSdata.Course_List[course_ind].method_list.Add(DataTransferObject.method);
                            DataTransferObject.method = null;

                            GenericXmlSerializer.WriteObject(DLSdata, "DLSdata.xml");
                        }

                        RefreshList();
                    }

                    break;

                default:
                    return;
            }
        }

        private void butDelete_Click(object sender, EventArgs e)
        {
            DLSdata DLSdata = GenericXmlSerializer.ReadObject<DLSdata>("DLSdata.xml");
            DialogResult res;

            switch (mode)
            {
                case 1:
                    int selectedInd = listBox.SelectedIndex;
                    if (selectedInd == -1) return;

                    if (DLSdata.Course_List[selectedInd].author != DLSdata.User.name)
                    {
                        MessageBox.Show("Операция не может быть выполнена.\nВы не являетесь автором этого курса","ОШИБКА");
                        return;
                    }
                    
                    res = MessageBox.Show(
                            $"Вы действительно хотите УДАЛИТЬ следующий курс?\n{DLSdata.Course_List[selectedInd].title}",
                            "Удаление курса",
                            MessageBoxButtons.YesNo
                            );           

                    if (res == DialogResult.Yes)
                    {
                        DLSdata.Course_List.RemoveAt(selectedInd);
                        GenericXmlSerializer.WriteObject(DLSdata, "DLSdata.xml");
                        RefreshList();
                    }
                    break;

                case 2:
                    int course_ind = DLSdata.Find_Course_ind(Current_Course_Title);
                    int method_ind = listBox.SelectedIndex;
                    if (method_ind == -1 || course_ind == -1) return;

                    if (DLSdata.Course_List[course_ind].author != DLSdata.User.name)
                    {
                        MessageBox.Show("Операция не может быть выполнена.\nВы не являетесь автором этого курса", "ОШИБКА");
                        return;
                    }

                    res = MessageBox.Show(
                            $"Вы действительно хотите УДАЛИТЬ следующую форму?\n{DLSdata.Course_List[course_ind].method_list[method_ind].title}",
                            "Удаление формы",
                            MessageBoxButtons.YesNo
                            );

                    if (res == DialogResult.Yes)
                    {
                        DLSdata.Course_List[course_ind].method_list.RemoveAt(method_ind);
                        GenericXmlSerializer.WriteObject(DLSdata, "DLSdata.xml");
                        RefreshList();
                    }
                    break;

                default:
                    return;
            }
        }

        private void butEdit_Click(object sender, EventArgs e)
        {
            DLSdata DLSdata = GenericXmlSerializer.ReadObject<DLSdata>("DLSdata.xml");
            Form frm;

            switch (mode)
            {
                case 1:
                    int selectedInd = listBox.SelectedIndex;
                    if (selectedInd == -1) return;

                    if (DLSdata.Course_List[selectedInd].author != DLSdata.User.name)
                    {
                        MessageBox.Show("Операция не может быть выполнена.\nВы не являетесь автором этого курса", "ОШИБКА");
                        return;
                    }

                    frm = new AddCourseForm(true);
                    frm.ShowDialog();
                    if (DataTransferObject.course != null)
                    {
                        DLSdata.Course_List[selectedInd].title = DataTransferObject.course.title;
                        DataTransferObject.course = null;
                        GenericXmlSerializer.WriteObject(DLSdata, "DLSdata.xml");
                        RefreshList();
                    }

                    break;

                case 2:
                    int course_ind = DLSdata.Find_Course_ind(Current_Course_Title);
                    int method_ind = listBox.SelectedIndex;
                    if (method_ind == -1 || course_ind == -1) return;

                    if (DLSdata.Course_List[course_ind].author != DLSdata.User.name)
                    {
                        MessageBox.Show("Операция не может быть выполнена.\nВы не являетесь автором этого курса", "ОШИБКА");
                        return;
                    }

                    Method met = DLSdata.Course_List[course_ind].method_list[method_ind];
                    string type = met.type;

                    if (type != BASIC_STR)
                    {
                        switch (type)
                        {
                            case "Параграф":
                                Text txt = (Text)met;
                                frm = new TextMethod(1, txt.title, txt.text);
                                break;

                            case "Изображение":
                                Picture pic = (Picture)met;
                                frm = new PictureMethod(1, pic.path, pic.title);
                                break;

                            case "Видеоролик":
                                Video vid = (Video)met;
                                frm = new VideoMethod(1, vid.title, vid.link, vid.duration);
                                break;

                            case "Тест":
                                Test test = (Test)met;
                                frm = new EditTestMethod(1, test);
                                break;

                            default:
                                return;
                        }

                        frm.ShowDialog();

                        if (DataTransferObject.method != null)
                        {
                            DataTransferObject.method.Calc_val();
                            DLSdata.Course_List[course_ind].method_list[method_ind] = DataTransferObject.method;
                            DataTransferObject.method = null;
                           
                            GenericXmlSerializer.WriteObject(DLSdata, "DLSdata.xml");
                        }

                        RefreshList();
                    }
                    break;

                default:
                    return;
            }

        }

        private void butOpen_Click(object sender, EventArgs e)
        {
            DLSdata DLSdata = GenericXmlSerializer.ReadObject<DLSdata>("DLSdata.xml");
            Form frm;

            switch (mode)
            {
                case 1:
                    string selectedString;
                    try
                    {
                        selectedString = listBox.SelectedItem.ToString();
                    }
                    catch { return; }

                        selectedString = (selectedString.Split('|'))[1];
                    Current_Course_Title = selectedString;

                    mode = 2;
                    RefreshList();
                    break;

                case 2:
                    int course_ind = DLSdata.Find_Course_ind(Current_Course_Title);
                    int method_ind = listBox.SelectedIndex;
                    if (method_ind == -1 || course_ind == -1) return;

                    Method met = DLSdata.Course_List[course_ind].method_list[method_ind];
                    string type = met.type;

                    if (type != BASIC_STR)
                    {
                        switch (type)
                        {
                            case "Параграф":
                                Text txt = (Text)met;
                                frm = new TextMethod(2, txt.title, txt.text);
                                break;

                            case "Изображение":
                                Picture pic = (Picture)met;
                                frm = new PictureMethod(2, pic.path, pic.title);
                                break;

                            case "Видеоролик":
                                Video vid = (Video)met;
                                frm = new VideoMethod(2, vid.title, vid.link, vid.duration);
                                break;

                            case "Тест":
                               Test test = (Test)met;
                                frm = new TestMethod(test);
                                break;

                            default:
                                return;
                        }

                        frm.ShowDialog();
                    }
                    break;

                default:
                    return;
            }
        }
    }
}
