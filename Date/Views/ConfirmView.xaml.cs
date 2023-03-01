using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Date.ViewModels;

namespace Date.Views
{
    /// <summary>
    /// Interaction logic for ConfirmView.xaml
    /// </summary>
    public partial class ConfirmView : UserControl
    {
        private ConfirmViewModel _vievModel;
        public ConfirmView()
        {
            InitializeComponent();
            DataContext = _vievModel = new ConfirmViewModel();
        }

        private void Confirm_Click(object sender, RoutedEventArgs e)
        {

            if (DateTime.TryParse(DpDate.Text, out DateTime date))
            {
                DateTime birthday = DpDate.SelectedDate.Value;
                DateTime currTime = DateTime.Now;
                var age = CalculateAge(birthday);

                if (DateTime.Compare(currTime, birthday) < 1)
                {
                    MessageBox.Show($"Are you living in the future? Be measure and pick your real birthdate");
                }
                else if (age == 0 || age > 135)
                {
                    MessageBox.Show($"Seriously?? Your cannot be {age} years old");
                }
                else
                {
                    string ageText = $"You are {age} years old";
                    string chineseZodiac = GetChineseZodiacSign(birthday);
                    string westernZodiac = GetWesternZodiacSign(birthday);

                    if (currTime.Day == birthday.Day && currTime.Month == birthday.Month)
                        ageText = $"Today is your {age}th birthday!!Live your best life sweety.";

                    TbChineseZodiac.Text = $"Following with chinese calendar you are a {chineseZodiac}";
                    TbWesternZodiac.Text = $"And with a western calendar - {westernZodiac}";
                    TbAge.Text = ageText;
                    TbAge.FontSize = 12;
                    TbAge.Foreground = Brushes.Black;

                }
            }
            else
            {
                MessageBox.Show("Invalid date. Chose from the calendar");
            }

        }

        private int CalculateAge(DateTime birthD)
        {
            DateTime currD = DateTime.Now;
            int age = 0;
            age = currD.Subtract(birthD).Days;
            age = age / 365;
            return age;
        }
        private string GetChineseZodiacSign(DateTime birthday)
        {
            int birthYear = birthday.Year;
            string chineseZodiacSign = "";

            switch (birthYear % 12)
            {
                case 0:
                    chineseZodiacSign = "Monkey";
                    break;
                case 1:
                    chineseZodiacSign = "Rooster";
                    break;
                case 2:
                    chineseZodiacSign = "Dog";
                    break;
                case 3:
                    chineseZodiacSign = "Pig";
                    break;
                case 4:
                    chineseZodiacSign = "Rat";
                    break;
                case 5:
                    chineseZodiacSign = "Ox";
                    break;
                case 6:
                    chineseZodiacSign = "Tiger";
                    break;
                case 7:
                    chineseZodiacSign = "Rabbit";
                    break;
                case 8:
                    chineseZodiacSign = "Dragon";
                    break;
                case 9:
                    chineseZodiacSign = "Snake";
                    break;
                case 10:
                    chineseZodiacSign = "Horse";
                    break;
                case 11:
                    chineseZodiacSign = "Sheep";
                    break;
            }
            return chineseZodiacSign;
        }
        private string GetWesternZodiacSign(DateTime dateOfBirth)
        {
            int month = dateOfBirth.Month;
            int day = dateOfBirth.Day;

            if ((month == 3 && day >= 21) || (month == 4 && day <= 19))
            {
                return "Aries";
            }
            else if ((month == 4 && day >= 20) || (month == 5 && day <= 20))
            {
                return "Taurus";
            }
            else if ((month == 5 && day >= 21) || (month == 6 && day <= 20))
            {
                return "Gemini";
            }
            else if ((month == 6 && day >= 21) || (month == 7 && day <= 22))
            {
                return "Cancer";
            }
            else if ((month == 7 && day >= 23) || (month == 8 && day <= 22))
            {
                return "Leo";
            }
            else if ((month == 8 && day >= 23) || (month == 9 && day <= 22))
            {
                return "Virgo";
            }
            else if ((month == 9 && day >= 23) || (month == 10 && day <= 22))
            {
                return "Libra";
            }
            else if ((month == 10 && day >= 23) || (month == 11 && day <= 21))
            {
                return "Scorpio";
            }
            else if ((month == 11 && day >= 22) || (month == 12 && day <= 21))
            {
                return "Sagittarius";
            }
            else if ((month == 12 && day >= 22) || (month == 1 && day <= 19))
            {
                return "Capricorn";
            }
            else if ((month == 1 && day >= 20) || (month == 2 && day <= 18))
            {
                return "Aquarius";
            }
            else if ((month == 2 && day >= 19) || (month == 3 && day <= 20))
            {
                return "Pisces";
            }

            return "Someting went wrong";
        }
    }
}
