#nullable disable

var cons_color = new Dictionary<string, int>();
for (int i = 0; i < 16; i++) cons_color.Add(((ConsoleColor)i).ToString(), i);

void msg_style (string message, string status = "Green") {
    //Black, DarkBlue, DarkGreen, DarkCyan, 
    //DarkRed, DarkMagenta, DarkYellow, Gray, 
    //DarkGray, Blue, Green, Cyan, 
    //Red, Magenta, Yellow, White

    Console.ForegroundColor = (ConsoleColor)cons_color[status];
    Console.WriteLine(message);
    Console.ForegroundColor = ConsoleColor.Gray;
}

msg_style("Введите число для проверки, является ли оно полиндромом", "Blue");

for(;;) {

    Console.Write("Введите пятизначное число (для выхода нажмите 'q'): ");
    string a = Console.ReadLine();

    if(a.ToLower() == "q") System.Environment.Exit(0);

    if(!Int32.TryParse(a, out int a_int)) {
        msg_style("Ошибка! Введено не число!", "DarkRed");
        continue;
    };

    if(a.Length != 5) {
        msg_style("Введенное число не является пятизначным", "DarkRed");
        continue;
    }

    string polindrom;
    if(a[0] == a[4] && a[1] == a[3]) polindrom = "Да";
    else polindrom = "Нет";
    
    msg_style($"{a} -> {polindrom}");
    //System.Environment.Exit(0);
}

