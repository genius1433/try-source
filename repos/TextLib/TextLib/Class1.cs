using System;

namespace TextLib
{
    /// <summary>
    /// Форматированный HTML текст.
    /// </summary>
    public class Text
    {
        /// <summary>
        /// Цвет шрифта.
        /// </summary>
        public ConsoleColor Color { get; internal set; } = ConsoleColor.White;

        /// <summary>
        /// Цвет заднего фона.
        /// </summary>
        public ConsoleColor BackgroundColor { get; internal set; } = ConsoleColor.Black;

        /// <summary>
        /// Жирный шрифт.
        /// </summary>
        public bool Bold { get; internal set; } = false;

        /// <summary>
        /// Наклонный шрифт.
        /// </summary>
        public bool Italic { get; internal set; } = false;

        /// <summary>
        /// Подчеркнутый шрифт.
        /// </summary>
        public bool Underline { get; internal set; } = false;

        /// <summary>
        /// Текст.
        /// </summary>
        public string Content { get; internal set; } = "";

        /// <summary>
        /// Уровень заголовка.
        /// </summary>
        public int HeaderLevel { get; internal set; } = 0;

        /// <summary>
        /// Шрифт.
        /// </summary>
        public string Font { get; internal set; } = "Arial";

        /// <summary>
        /// Размер шрифта.
        /// </summary>
        public int Size { get; internal set; } = 12;

        /// <summary>
        /// Создать новый экземпляр класса текст.
        /// </summary>
        /// <param name="content"> Текст. </param>
        public Text(string content)
        {
            // Проверяем входные данные на корректность.
            if (string.IsNullOrEmpty(content))
            {
                throw new ArgumentNullException(nameof(content));
            }

            // Устанавливаем значение.
            Content = content;
        }

        /// <summary>
        /// Напечатать текст.
        /// </summary>
        /// <returns> Текст с разметкой HTML. </returns>
        public string Print()
        {
            // Если уровень заголовка равен нулю, 
            // то используем тег обычного текста P,
            // иначе используем тег H1, H2, ... , H6, в зависимости от значения.
            var mainTag = HeaderLevel == 0 ? "P" : $"H{HeaderLevel}";

            // Форматируем теги в соответствии со свойствами.
            var formatedContent = $"<{mainTag} style=\"background-color: {BackgroundColor}; \">" +
                $"<FONT size=\"{Size}\" color=\"{Color}\" face=\"{Font}\">" +
                (Bold == true ? "<STRONG>" : "") +
                (Italic == true ? "<EM>" : "") +
                (Underline == true ? "<U>" : "") +
                Content +
                (Underline == true ? "</U>" : "") +
                (Italic == true ? "</EM>" : "") +
                (Bold == true ? "</STRONG>" : "") +
                $"</FONT></{mainTag}>";

            // Возвращаем форматированный текст.
            return formatedContent;
        }

        /// <summary>
        /// Приведение объекта к строке.
        /// </summary>
        /// <returns> Хранимый текст. </returns>
        public override string ToString()
        {
            return Content;
        }
    }
    /// <summary>
    /// Строитель, формирующий оформление текста.
    /// </summary>
    public static class TextBuilder
    {
        /// <summary>
        /// Установить шрифт.
        /// </summary>
        /// <param name="text"> Форматируемый текст. </param>
        /// <param name="font"> Шрифт. </param>
        /// <returns> Отформатированный текст. </returns>
        public static Text Font(this Text text, Fonts font)
        {
            // Получаем имя шрифта из перечисления и устанавливаем значение.
            text.Font = Enum.GetName(typeof(Fonts), font);

            // Возвращаем измененный текст.
            return text;
        }

        /// <summary>
        /// Установить размер шрифта.
        /// </summary>
        /// <param name="text"> Форматируемый текст. </param>
        /// <param name="size"> Размер шрифта. </param>
        /// <returns> Отформатированный текст. </returns>
        public static Text Size(this Text text, int size)
        {
            // Устанавливаем крайние допустимые значения
            const int MinFontSize = 6;
            const int MaxFontSize = 72;

            if (size <= MinFontSize)
            {
                // Если шрифт меньше либо равен минимальному,
                // то устанавливаем минимальное значение.
                text.Size = MinFontSize;
            }
            else if (size >= MaxFontSize)
            {
                // Если шрифт больше либо равен максимальному,
                // то устанавливаем максимальное значение.
                text.Size = MaxFontSize;
            }
            else
            {
                // Иначе устанавливаем соответствующее значение.
                text.Size = size;
            }

            // Возвращаем измененный текст.
            return text;
        }

        /// <summary>
        /// Установить цвет шрифта. 
        /// </summary>
        /// <param name="text"> Форматируемый текст. </param>
        /// <param name="color"> Цвет шрифта. </param>
        /// <returns> Отформатированный текст. </returns>
        public static Text Color(this Text text, ConsoleColor color)
        {
            // Устанавливаем свойства и возвращаем измененный текст.
            text.Color = color;
            return text;
        }

        /// <summary>
        /// Установить цвет заднего фона. 
        /// </summary>
        /// <param name="text"> Форматируемый текст. </param>
        /// <param name="color"> Цвет заднего фона. </param>
        /// <returns> Отформатированный текст. </returns>
        public static Text BackgroundColor(this Text text, ConsoleColor color)
        {
            // Устанавливаем свойства и возвращаем измененный текст.
            text.BackgroundColor = color;
            return text;
        }

        /// <summary>
        /// Использовать жирный шрифт. 
        /// </summary>
        /// <param name="text"> Форматируемый текст. </param>
        /// <param name="bold"> true - использовать, false - нет. </param>
        /// <returns> Отформатированный текст. </returns>
        public static Text Bold(this Text text, bool bold)
        {
            // Устанавливаем свойства и возвращаем измененный текст.
            text.Bold = bold;
            return text;
        }

        /// <summary>
        /// Использовать наклонный шрифт.
        /// </summary>
        /// <param name="text"> Форматируемый текст. </param>
        /// <param name="italic"> true - использовать, false - нет. </param>
        /// <returns> Отформатированный текст. </returns>
        public static Text Italic(this Text text, bool italic)
        {
            // Устанавливаем свойства и возвращаем измененный текст.
            text.Italic = italic;
            return text;
        }

        /// <summary>
        /// Использовать подчеркнутый шрифт. 
        /// </summary>
        /// <param name="text"> Форматируемый текст. </param>
        /// <param name="underline"> true - использовать, false - нет. </param>
        /// <returns> Отформатированный текст. </returns>
        public static Text Underline(this Text text, bool underline)
        {
            // Устанавливаем свойства и возвращаем измененный текст.
            text.Underline = underline;
            return text;
        }

        /// <summary>
        /// Задать уровень заголовка.
        /// </summary>
        /// <param name="text"> Форматируемый текст. </param>
        /// <param name="headerLevel"> 0 - обычный текст, 1-6 - заголовки. </param>
        /// <returns> Отформатированный текст. </returns>
        public static Text HeaderLevel(this Text text, int headerLevel)
        {
            // Задаем крайние корректные значения.
            const int NormalText = 0;
            const int MinHeader = 6;

            if (headerLevel <= NormalText)
            {
                // Если задано значение меньше или равное нуля используем обычный текст.
                text.HeaderLevel = NormalText;
            }
            else if (headerLevel >= MinHeader)
            {
                // Если задано значение большее либо равное шести используем заголовок H6.
                text.HeaderLevel = MinHeader;
            }
            else
            {
                // Иначе устанавливаем соответствующий уровень заголовка.
                text.HeaderLevel = headerLevel;
            }

            // Возвращаем измененный текст.
            return text;
        }
    }
}
