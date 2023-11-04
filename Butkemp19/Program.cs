Department dep1 = new Department(0, "Информационные технологии");
Department dep2 = new Department(1, "Отдел кадров");
Department dep3 = new Department(2, "Бухгалтерия");

Worker worker1 = new Worker(0, 0, "Александр Стогний", 24, 100000);
Worker worker2 = new Worker(1, 0, "Мария Степановна", 23, 90000);
Worker worker3 = new Worker(2, 1, "Василий Петрович", 33, 70000);
Worker worker4 = new Worker(3, 2, "Игнат Петрович", 42, 100000);
// Console.WriteLine(worker1);
// Console.WriteLine(worker2);
// Console.WriteLine(worker3);
// Console.WriteLine(worker4);
DataBase db = new DataBase();
db.appendWorker(worker1);
db.appendWorker(worker2);
db.appendWorker(worker3);
db.appendWorker(worker4);

db.appendDep(dep1);
db.appendDep(dep2);
db.appendDep(dep3);

Console.WriteLine(db.selectAllDep());
Console.WriteLine("================");
Console.WriteLine(db.selectAllWorker());
Console.WriteLine("================");
var report = db.report();
foreach (var item in report)
{
    Console.WriteLine($"{item.Item1}, {item.Item2}, {item.Item3}, {item.Item4} руб.");
}