// Напишите программу, которая будет
// выдавать название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница

Console.WriteLine("Enter day number : ");
string enterDay = Console.ReadLine();
int day = Convert.ToInt32(enterDay);
string WeekDay = "Monday";

if (day == 1 ) WeekDay = "Monday";
if (day == 2 ) WeekDay = "Tuesday";
if (day == 3 ) WeekDay = "Wednesday";
if (day == 4 ) WeekDay = "Thursday";
if (day == 5 ) WeekDay = "Friday";
if (day == 6 ) WeekDay = "Saturday";
if (day == 7 ) WeekDay = "Sunday";

Console.WriteLine(WeekDay);
