using System;
using System.Collections.Generic;
using System.Text;

namespace FormatSplitterCore
{
    public class HelpProviderFS
    {
        public string HelpInfo { get { return helpInfo; } }

        private string helpInfo = "Выберите узел в окне слева, разверните его." +
            "Слева вы должны увидеть все директории, содержащиеся в выбранном вами узле," +
            "а справа - директории расширений." +
            "Выберите директорию расширения, откроется окно с файлами данного расширения," +
            "выберите определённый файл, нажмите правой кнопкой мыши для выбора действия." +
            "Чтобы завершить работу программы, нажмите соответствующую клавишу";
    }
}
