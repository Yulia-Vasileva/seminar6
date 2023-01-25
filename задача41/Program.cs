// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь. 
//Ввод чисел останавливается при помощи ввода стоп-слова "stop" и производится при помощи нажатия Enter

int number=0;
int count = 0;

while (true) 

 {
     Console.WriteLine("Введите число. Чтобы остановить ввод, введите stop:"); 
      string input = Console.ReadLine(); 
               
       if (input == "stop") 
                
        break; 
        
       number = int.Parse(input); 
           
       if (number>0)
        {
         count++;
             
        }
            
 }
Console.WriteLine($"Количество положительных чисел = {count}");
            

