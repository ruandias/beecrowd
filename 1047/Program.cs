string[] valores = Console.ReadLine().Split(' ');

int fisrtHour = int.Parse(valores[0]);
int lastHour = int.Parse(valores[2]);

int firstMinute = int.Parse(valores[1]);
int lastMinute = int.Parse(valores[3]);

int start = (fisrtHour * 60) + firstMinute;
int end = (lastHour * 60) + lastMinute;

int duration = end - start;

if (duration <= 0)
{
    duration += 24 * 60;
}

int hours = duration / 60;
int minutes = duration % 60;


Console.WriteLine($"O JOGO DUROU {hours} HORA(S) E {minutes} MINUTO(S)");
