using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Courseeapp21
{
    public partial class Form1 : Form
    {
        private XDocument scheduleDoc;
        private string doctorsXmlFilePath = "doctors.xml";
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn(
    int nLeftRect,
    int nTopRect,
    int nRightRect,
    int nBottomRect,
    int nWidthEllipse,
    int nHeightEllipse

);
        public Form1() 
        {
            InitializeComponent();
            dataGridView1.Columns.Add("Name", "Ім`я");
            dataGridView1.Columns.Add("Cabinet", "Кабінет");
            dataGridView1.Columns.Add("Fluragrag", "Флюорографія");
            dataGridView1.Columns.Add("StartTime", "Час початку");
            dataGridView1.Columns.Add("EndTime", "Час закінчення");

            scheduleDoc = XDocument.Load("doctors.xml");

            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            pnlNav.Height = buttonMain.Height;
            pnlNav.Top = buttonMain.Top;
            pnlNav.Left = buttonMain.Left;

            comboBox2.Items.Add("Понеділок");
            comboBox2.Items.Add("Вівторок");
            comboBox2.Items.Add("Середа");
            comboBox2.Items.Add("Четвер");
            comboBox2.Items.Add("П`ятниця");

            comboBox3.Items.Add("Понеділок");
            comboBox3.Items.Add("Вівторок");
            comboBox3.Items.Add("Середа");
            comboBox3.Items.Add("Четвер");
            comboBox3.Items.Add("П`ятниця");

            comboBox4.Items.Add("9:00");
            comboBox4.Items.Add("10:00");
            comboBox4.Items.Add("11:00");
            comboBox4.Items.Add("12:00");
            comboBox4.Items.Add("13:00");

            comboBox5.Items.Add("14:00");
            comboBox5.Items.Add("15:00");
            comboBox5.Items.Add("16:00");
            comboBox5.Items.Add("17:00");
            comboBox5.Items.Add("18:00");


            comboBox1.Visible = false;
            comboBox2.Visible = false;
            button2.Visible = false;
            textBox2.Visible = false;
            textBox1.Visible = false;
            label10.Visible = false;
            label12.Visible = false;

            buttonAdd.Visible = false;
            comboBox4.Visible = false;
            comboBox5.Visible = false;
            comboBox3.Visible = false;
            labelDay.Visible = false;
            labelCabinet.Visible = false;
            labelFlur.Visible = false;
            labelTime.Visible = false;
            label14.Visible = false;
            textBoxCabinet.Visible = false;
            textBoxName.Visible = false;
            textBox3.Visible = false;
            textBox1.PasswordChar = '*';
            dataGridView1.Visible = false;
            buttonPrepareInfo.Click += buttonPrepareInfo_Click;
            button1.Visible = false;
            buttonPrepareInfo.Visible = false;
            panel3.Visible = false;
            buttonDelete.Visible = false;
            PopulateDoctorsComboBox();




        }

        private void buttonGraf_Click(object sender, EventArgs e)
        {
            pnlNav.Height = buttonGraf.Height;
            pnlNav.Top = buttonGraf.Top;
            pnlNav.Left = buttonGraf.Left;
            labelHead.Text = "Графік";
            comboBox1.Visible = false;
            comboBox2.Visible = true;
            button2.Visible = false;
            textBox2.Visible = false;
            textBox1.Visible = false;
            label10.Visible = false;
            label12.Visible = false;

            buttonAdd.Visible = false;
            comboBox4.Visible = false;
            comboBox5.Visible = false;
            comboBox3.Visible = false;
            labelDay.Visible = false;
            labelCabinet.Visible = false;
            labelFlur.Visible = false;
            labelTime.Visible = false;
            label14.Visible = false;
            textBoxCabinet.Visible = false;
            textBoxName.Visible = false;
            textBox3.Visible = false;
            dataGridView1.Visible = true;
            button1.Visible = true;
            buttonPrepareInfo.Visible = true;
            panel3.Visible = true;
            buttonDelete.Visible = false;


        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonMain_Click(object sender, EventArgs e)
        {

            pnlNav.Height = buttonMain.Height;
            pnlNav.Top = buttonMain.Top;
            pnlNav.Left = buttonMain.Left;
            labelHead.Text = "Головна";
            comboBox1.Visible = false;
            comboBox2.Visible = false;
            button2.Visible = false;
            textBox2.Visible = false;
            textBox1.Visible = false;
            label10.Visible = false;
            label12.Visible = false;
            buttonAdd.Visible = false;
            comboBox4.Visible = false;
            comboBox5.Visible = false;
            comboBox3.Visible = false;
            labelDay.Visible = false;
            labelCabinet.Visible = false;
            labelFlur.Visible = false;
            labelTime.Visible = false;
            label14.Visible = false;
            textBoxCabinet.Visible = false;
            textBoxName.Visible = false;
            textBox3.Visible = false;
            dataGridView1.Visible = false;
            button1.Visible = false;
            buttonPrepareInfo.Visible = false;
            panel3.Visible = false;
            buttonDelete.Visible = false;


        }
        private void button2_Click(object sender, EventArgs e)
        {

            string username = "admin";
            string password = "health1121";
            if (textBox2.Text == username && textBox1.Text == password)
            {
                button2.Visible = false;
                buttonAdd.Visible = true;
                comboBox4.Visible = true;
                comboBox5.Visible = true;
                comboBox3.Visible = true;
                labelDay.Visible = true;
                labelCabinet.Visible = true;
                labelFlur.Visible = true;
                labelTime.Visible = true;
                label14.Visible = true;
                textBoxCabinet.Visible = true;
                textBoxName.Visible = true;
                textBox3.Visible = true;
                buttonDelete.Visible = true;
                comboBox1.Visible = true;


            }
            else
            {
                label13.Text = "Ви вввели невірно логін чи пароль";

            }
        }

        private void buttonAdmin_Click(object sender, EventArgs e)
        {
            pnlNav.Height = buttonAdmin.Height;
            pnlNav.Top = buttonAdmin.Top;
            pnlNav.Left = buttonAdmin.Left;
            buttonAdd.Visible = false;
            button2.Visible = true;
            textBox2.Visible = true;
            textBox1.Visible = true;
            label10.Visible = true;
            label12.Visible = true;
            comboBox1.Visible = false;
            comboBox2.Visible = false;
            labelHead.Text = "Admin";
            dataGridView1.Visible = false;
            button1.Visible = false;
            buttonPrepareInfo.Visible = false;
            panel3.Visible = false;
            buttonDelete.Visible = false;


        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            string cabinet = textBoxCabinet.Text;
            string fluragrag = textBox3.Text;
            string day = comboBox3.Text;
            string start_time = comboBox4.Text;
            string end_time = comboBox5.Text;

            // Создание нового элемента для врача
            XElement newDoctor = new XElement("doctor",
                new XElement("name", name),
                new XElement("cabinet", cabinet),
                new XElement("Флюраграфія", fluragrag),
                new XElement("Час_початку", start_time),
                new XElement("Час_кінець", end_time),
                new XElement("День", day)
            );

            // Добавление нового элемента в XML-документ
            scheduleDoc.Element("doctors").Add(newDoctor);

            // Сохранение изменений в XML-файл
            scheduleDoc.Save(doctorsXmlFilePath);

            // Оповещение пользователя об успешном добавлении данных
            MessageBox.Show("Дані про лікаря додані до XML-файлу.");

            // Очистка полей ввода
            ClearInputFields();
        }


        private void ClearInputFields()
        {
            // Очистка полей ввода формы
            textBoxName.Clear();
            textBoxCabinet.Clear();
            textBox3.Clear();
            comboBox3.SelectedIndex = -1;
            comboBox4.SelectedIndex = -1;
            comboBox5.SelectedIndex = -1;
        }
        private void DisplayTerapistsEndingToday(string selectedDay)
        {
            // Получение текущей даты
            // Получение текущей даты
            DateTime today = DateTime.Today;

            // Загрузка XML-файла с расписанием врачей
            XDocument doc = XDocument.Load("doctors.xml");

            // Поиск всех врачей, у которых прием заканчивается в выбранный день
            var therapistsEndingSelectedDay = doc.Descendants("doctor")
                                                 .Where(d => d.Element("День").Value == selectedDay);

            // Находим самое позднее время завершения приема в выбранный день
             TimeSpan latestEndTime = therapistsEndingSelectedDay.Max(d => TimeSpan.Parse(d.Element("Час_кінець").Value));

            // Находим всех врачей, у которых время завершения приема совпадает с самым поздним временем
            var latestTherapists = therapistsEndingSelectedDay.Where(d => TimeSpan.Parse(d.Element("Час_кінець").Value) == latestEndTime);

            // Вывод информации о найденных терапевтах
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Терапевти, що завершують прийом в {selectedDay} у пізнішому часі ({latestEndTime}):");

            foreach (var therapist in latestTherapists)
            {
                sb.AppendLine($"Ім`я: {therapist.Element("name").Value}");
                sb.AppendLine($"Кабінет: {therapist.Element("cabinet").Value}");
                sb.AppendLine($"Час завершення прийому: {therapist.Element("Час_кінець").Value}");
                sb.AppendLine();
            }

            // Вывод информации на форму приложения
            MessageBox.Show(sb.ToString());
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedDay = comboBox2.SelectedItem.ToString();

            // Очищаем DataGridView перед загрузкой новых данных
            dataGridView1.Rows.Clear();

            // Загружаем расписание из XML файла для выбранного дня недели
            foreach (XElement doctor in scheduleDoc.Descendants("doctor"))
            {
                string day = doctor.Element("День").Value;
                if (day == selectedDay)
                {
                    string name = doctor.Element("name").Value;
                    string cabinet = doctor.Element("cabinet").Value;
                    string fluragrag = doctor.Element("Флюраграфія").Value;
                    string startTime = doctor.Element("Час_початку").Value;
                    string endTime = doctor.Element("Час_кінець").Value;

                    // Добавляем запись в DataGridView
                    dataGridView1.Rows.Add(name, cabinet, fluragrag, startTime, endTime);
                }
            }

            // Вызов метода для отображения терапевтов, завершающих прием в выбранный день
            DisplayTerapistsEndingToday(selectedDay);
        }
        private XElement BinarySearchDoctorByName(string name)
        {
            // Получаем всех докторов и сортируем их по имени (если они не отсортированы)
            var doctors = scheduleDoc.Descendants("doctor")
                                     .OrderBy(d => d.Element("name").Value)
                                     .ToList();

            int left = 0;
            int right = doctors.Count - 1;

            while (left <= right)
            {
                int mid = (left + right) / 2;
                string midName = doctors[mid].Element("name").Value;

                int comparison = string.Compare(midName, name, StringComparison.OrdinalIgnoreCase);

                if (comparison == 0)
                {
                    return doctors[mid];
                }
                else if (comparison < 0)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            return null; // Доктор не найден
        }


        private void button1_Click(object sender, EventArgs e)
        {
            // Загрузка XML-файла с расписанием врачей
            XDocument doc = XDocument.Load("doctors.xml");

            // Поиск всех врачей, начинающих прием в пятницу после 12:00
            var fridayDoctorsAfterNoon = doc.Descendants("doctor")
                                            .Where(d => d.Element("День").Value == "П`ятниця" &&
                                                        TimeSpan.Parse(d.Element("Час_початку").Value) >= TimeSpan.Parse("12:00"));

            // Вывод информации о найденных врачах
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Лікарі, які розпочинають прийом у п'ятницю після 12:00:");

            foreach (var doctor in fridayDoctorsAfterNoon)
            {
                sb.AppendLine($"Ім`я: {doctor.Element("name").Value}");
                sb.AppendLine($"Кабінет: {doctor.Element("cabinet").Value}");
                sb.AppendLine($"Час початку прийому: {doctor.Element("Час_початку").Value}");
                sb.AppendLine($"Час завершення прийому: {doctor.Element("Час_кінець").Value}");
                sb.AppendLine();
            }

            // Вывод информации на форму приложения
            MessageBox.Show(sb.ToString());
        }
        private void buttonPrepareInfo_Click(object sender, EventArgs e)
        {
            // Заг  XDocument doc = XDocument.Load("doctors.xml");

            // Формирование информации о всех сотрудниках, отсортированных по дню недели
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Інформація про співробітників, відсортована за днями тижня:");

            var sortedEmployees = XDocument.Load("doctors.xml")
                               .Descendants("doctor")
                               .OrderBy(d => d.Element("День").Value);

            foreach (var employee in sortedEmployees)
            {
                sb.AppendLine($"Имя: {employee.Element("name").Value}");
                sb.AppendLine($"Кабинет: {employee.Element("cabinet").Value}");
                sb.AppendLine($"День недели: {employee.Element("День").Value}");
                sb.AppendLine($"Время начала приема: {employee.Element("Час_початку").Value}");
                sb.AppendLine($"Время завершения приема: {employee.Element("Час_кінець").Value}");
                sb.AppendLine();
            }

            // Предложение пользователю сохранить информацию в файл
            DialogResult result = MessageBox.Show("Бажаєте зберегти інформацію про співробітників у файл?", "Збереження файла", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Отображение диалогового окна сохранения файла
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt";
                    saveFileDialog.Title = "Сохранить информацию о сотрудниках";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            // Сохранение информации о сотрудниках в выбранный файл
                            File.WriteAllText(saveFileDialog.FileName, sb.ToString());
                            MessageBox.Show("Файл успішно збережено.", "Успіх");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Помилка збереження файлу: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Создаем объект SoundPlayer и указываем путь к аудиофайлу
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\koles\Downloads\skill (online-audio-converter.com).wav");

            try
            {
                // Воспроизводим звук
                player.Play();
            }
            catch (Exception ex)
            {
                // Обрабатываем возможные ошибки
                MessageBox.Show($"Ошибка воспроизведения звука: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
        private void CheckFluorographyCabinet()
        {
            // Получение значений времени и дня недели
            string inputTime = textBoxTime.Text; // Время в формате HH:mm
            string selectedDay = comboBox2.SelectedItem.ToString();

            // Проверка наличия данных о приеме в указанное время
            bool isReceiving = scheduleDoc.Descendants("doctor")
                                          .Where(d => d.Element("День").Value == selectedDay)
                                          .Any(d =>
                                          {
                                              TimeSpan startTime = TimeSpan.Parse(d.Element("Час_початку").Value);
                                              TimeSpan endTime = TimeSpan.Parse(d.Element("Час_кінець").Value);
                                              TimeSpan input = TimeSpan.Parse(inputTime);

                                              return input >= startTime && input <= endTime;
                                          });

            // Вывод результата
            if (isReceiving)
            {
                MessageBox.Show("Кабінет флюорографии приймає в вказаний час.", "Результат");
            }
            else
            {
                MessageBox.Show("Кабинет флюорографии не принимает в указанное время.", "Результат");
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            CheckFluorographyCabinet();
        }

        private void PopulateDoctorsComboBox()
        {
            // Очистить ComboBox перед загрузкой новых данных
            comboBox1.Items.Clear();

            // Загрузить имена всех врачей из XML-файла и добавить их в ComboBox
            foreach (XElement doctor in scheduleDoc.Descendants("doctor"))
            {
                string name = doctor.Element("name").Value;
                comboBox1.Items.Add(name);
            }
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            // Проверить, был ли выбран врач для удаления
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Будь ласка, оберіть лікаря для видалення.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Получить имя выбранного врача
            string selectedDoctorName = comboBox1.SelectedItem.ToString();

            // Найти врача с помощью бинарного поиска
            XElement doctorToDelete = BinarySearchDoctorByName(selectedDoctorName);

            if (doctorToDelete != null)
            {
                doctorToDelete.Remove();

                // Сохранить изменения в XML-файле
                scheduleDoc.Save(doctorsXmlFilePath);

                MessageBox.Show($"Лікар {selectedDoctorName} успішно видален.", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Обновить список врачей в ComboBox и отобразить обновленную информацию
                PopulateDoctorsComboBox();
            }
            else
            {
                MessageBox.Show($"Лікар {selectedDoctorName} не найден.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }

}



















