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

int enter_number (string info) {
    for(;;) {

        Console.Write(info);
        string a = Console.ReadLine();

        if(a.ToLower() == "q") System.Environment.Exit(0);

        if(!Int32.TryParse(a, out int a_int)) {
            msg_style("Ошибка! Введено не число!", "DarkRed");
            continue;
        };
        return a_int;
    }
}

msg_style("Найти расстояние между координатами двух точек", "Blue");

Console.WriteLine("Введите координату точки А (для выхода введите 'q')");
int x1 = enter_number ("x: ");
int y1 = enter_number ("y: ");
int z1 = enter_number ("z: ");

Console.WriteLine("Введите координату точки B");
int x2 = enter_number ("x: ");
int y2 = enter_number ("y: ");
int z2 = enter_number ("z: ");

double result = Math.Sqrt(Math.Pow(x1-x2, 2) + Math.Pow(y1-y2, 2) + Math.Pow(z1-z2, 2));
string s_result = string.Format("{0:f2}", result);
msg_style($"A({x1}, {y1}, {z1}); B({x2}, {y2}, {z2}) -> {s_result}");