/// Метод создания массива с элементами длинной <= wordLength на основе заданного массива
string[] ShortWordsArray(string[]incomeArray, int wordLength)   
{
    string[] newArray = new string [0];     // Новый массив изначально пустой.
    int j = 0;
    int lengthArray = incomeArray.Length;   // Длина заданного массива
    for (int i = 0; i < lengthArray; i++)  
    // В цикле проверяем длину каждого элемента массива и записываем короткие слова в новый массив.
    {   
        if (incomeArray[i].Length <= wordLength)
            {
                newArray[j] = incomeArray[i];
            }
    }
    return newArray;
}

Console.WriteLine("Введите все слова в одну строку через пробел: ");
// Считаем строку, разделим ее на слова, и внесем в массив)
string[] array = Console.ReadLine().Split(' ').ToArray(); 
// Console.WriteLine(String.Join(" ", array));