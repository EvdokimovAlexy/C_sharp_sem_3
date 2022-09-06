//Напишите программу, которая по заданному номеру четверти, 
//показывает диапазон возможных координат точек в этой четверти (x и y).
 Console.WriteLine("Input Quadrant number");
int quadrant = Convert.ToInt32(Console.ReadLine());
void GetDiapazon(int quadrant)
{
    switch(quadrant)
    {
        case 1:
            Console.WriteLine("допустимый диапазон координат точек в этом квадранте x>0, y>0");
            break;

        case 2:
            Console.WriteLine("допустимый диапазон координат точек в этом квадранте x<0, y>0");
            break;

        case 3:
            Console.WriteLine("допустимый диапазон координат точек в этом квадранте x<0, y<0");
            break;

        case 4:
            Console.WriteLine("допустимый диапазон координат точек в этом квадранте x>0, y<0");
            break;
    }
}
GetDiapazon(quadrant);
