using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PhoneHolder.Model; // Подключение пространства имён с классом Constants


namespace PhoneHolder.View
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void textHeight_TextChanged(object sender, EventArgs e)
        {
            ValidateParameter(textHeight, Constants.MIN_HEIGHT, Constants.MAX_HEIGHT);
            ValidateAllParameters();
        }

        private void textTiltAngle_TextChanged(object sender, EventArgs e)
        {
            ValidateParameter(textTiltAngle, Constants.MIN_TILT_ANGLE, Constants.MAX_TILT_ANGLE);
            ValidateAllParameters();
        }

        private void textBaseWidth_TextChanged(object sender, EventArgs e)
        {
            ValidateParameter(textBaseWidth, Constants.MIN_BASE_WIDTH, Constants.MAX_BASE_WIDTH);
            ValidateAllParameters();
        }

        private void textHolderWidth_TextChanged(object sender, EventArgs e)
        {
            ValidateParameter(textHolderWidth, Constants.MIN_HOLDER_WIDTH, Constants.MAX_HOLDER_WIDTH);
            ValidateAllParameters();
        }

        private void textClampWidth_TextChanged(object sender, EventArgs e)
        {
            ValidateParameter(textClampWidth, Constants.MIN_CLAMP_WIDTH, Constants.MAX_CLAMP_WIDTH);
            ValidateAllParameters();
        }



        private void ValidateParameter(TextBox textBox, float minValue, float maxValue)
        {
            string input = textBox.Text;

            // Очищаем ввод от недопустимых символов
            input = Validator.TextBoxCheck(input);

            // Обновляем текст в TextBox без недопустимых символов
            textBox.Text = input;

            // Перемещаем курсор в конец
            textBox.SelectionStart = textBox.Text.Length;

            if (string.IsNullOrWhiteSpace(input))
            {
                // Параметр не введён
                textBox.BackColor = Color.White;
            }
            else if (float.TryParse(input, out float value))
            {
                if (value >= minValue && value <= maxValue)
                {
                    // Значение валидно
                    textBox.BackColor = Color.LightGreen;
                }
                else
                {
                    // Значение вне диапазона
                    textBox.BackColor = Color.LightCoral;
                }
            }
            else
            {
                // Некорректный ввод
                textBox.BackColor = Color.LightCoral;
            }
        }

        private void ValidateAllParameters()
        {
            bool isValid = true;

            // Список всех TextBox для параметров
            TextBox[] parameterTextBoxes = { textHeight, textTiltAngle, textBaseWidth, textHolderWidth, textClampWidth };

            foreach (var textBox in parameterTextBoxes)
            {
                if (textBox.BackColor != Color.LightGreen)
                {
                    isValid = false;
                    break;
                }
            }

            // Дополнительная проверка зависимостей
            if (isValid)
            {
                float holderWidth = float.Parse(textHolderWidth.Text);
                float clampWidth = float.Parse(textClampWidth.Text);

                if (clampWidth >= holderWidth)
                {
                    // Ширина зажима должна быть меньше ширины держателей
                    textClampWidth.BackColor = Color.LightCoral;
                    isValid = false;
                }
            }

            buttonBuild.Enabled = isValid;
        }
        //instead of btm - button
        private void btnBuild_Click(object sender, EventArgs e)
        {
            try
            {
                // Создаём объект параметров
                PhoneHolderParameters parameters = new PhoneHolderParameters
                {
                    Height = float.Parse(textHeight.Text),
                    TiltAngle = float.Parse(textTiltAngle.Text),
                    BaseWidth = float.Parse(textBaseWidth.Text),
                    HolderWidth = float.Parse(textHolderWidth.Text),
                    ClampWidth = float.Parse(textClampWidth.Text)
                };

                // Здесь можно добавить код для построения модели в NanoCAD
                MessageBox.Show("Модель держателя телефона успешно создана.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Закрываем форму, если необходимо
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при создании модели: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}