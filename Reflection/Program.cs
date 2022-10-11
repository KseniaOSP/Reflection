// See https://aka.ms/new-console-template for more information
using System.Globalization;
using System.Reflection;
using Reflection;

// Получаем тип класса Calc
Type typeCalc = typeof(Calc);

// Применим метод GetMembers и выведем все доступные элементы типа
foreach (MemberInfo member in typeCalc.GetMembers())
{
    Console.WriteLine($"{member.DeclaringType} {member.MemberType} {member.Name}");
}

// Инстанцируем экземпляр класса (у типа класса находим
// конструктор без параметров, и вызываем его, передавая ноль
// аргументов) 
ConstructorInfo constr = typeCalc.GetConstructor(new Type[0]);
object calc = constr.Invoke(new Object[0]);

// Получаем информацию о полях класса (указываем, что нам нужно nonpublic instance поле) 
FieldInfo leftField = typeCalc.GetField("left", BindingFlags.NonPublic | BindingFlags.Instance);
FieldInfo rightField = typeCalc.GetField("right", BindingFlags.NonPublic | BindingFlags.Instance);

// Получаем значение полей
var value1 = leftField.GetValue(calc);
var value2 = rightField.GetValue(calc);

// Получаем информацию о методе класса
MethodInfo methodInfo = typeCalc.GetMethod(nameof(Calc.Subtract));

// Вызываем метод
object result = methodInfo.Invoke(calc, new object[] {value1, value2});

// Выводим значение
Console.WriteLine(result);

