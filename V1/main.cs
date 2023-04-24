/*
 * Sussy Baka Impostor uwu V1.1.0O discord bot (SBIU V1.1.0O)
 * (C) HtB#1526 2021-2023
 */
/*
    Обозначение версий саси баки:
        D ==> не стабильная, которая не прошла тестирование (Debug)
        S ==> стабильная, прошла аптайм 2 дня или больше (Stable)
        NS ==> стабильная, но не прошла аптайм 2 дня или больше (Not Stable)
        O ==> устаревшая версия (Outdated)
*/
using System;
using System.Threading.Tasks;
using Discord;
using Discord.WebSocket;

namespace SBIU_V1 //да я обновил namespace, вопросы?
{
    class Program
    {
        DiscordSocketClient client;
        static void Main(string[] args) => new Program().MainAsync().GetAwaiter().GetResult();

        private async Task MainAsync()
        {
            client = new DiscordSocketClient();
            client.MessageReceived += CommandsHandler;
            client.Log += Log;
            /*string token = "";
            await client.LoginAsync(TokenType.Bot, token);*/
            //переделал 07.03.22
            await client.LoginAsync(TokenType.Bot, "токен"); 
            await client.StartAsync();
            //Console.ReadLine();
            //обновил 07.03.22
            await Task.Delay(-1);

        }

        private Task Log(LogMessage msg)
        {
            Console.WriteLine(msg.ToString());
            return Task.CompletedTask;
        }

        private Task CommandsHandler(SocketMessage msg)
        {
            if (!msg.Author.IsBot)
                switch (msg.Content)
                {
                    case "привет":
                        {
                            msg.Channel.SendMessageAsync($"Привет, {msg.Author}");
                            Console.WriteLine($"{DateTime.Now}: {msg.Author} использует комманду !привет");
                            break;
                        }
                    case "!Рандом":
                        {
                            Random rnd = new();
                            msg.Channel.SendMessageAsync($"Выпало число {rnd.Next(1, 60)}");
                            Console.WriteLine($"{DateTime.Now}: {msg.Author} использует комманду !Рандом");
                            break;
                        }
                    case "!опиши одного из друзей разработчика":
                        {
                            msg.Channel.SendMessageAsync($"его зовут саня, он весёлый, взорвал кегу и вообще устроил апокалипсис");
                            Console.WriteLine($"{DateTime.Now}: {msg.Author} использует комманду !опиши одного из друзей разработчика");
                            break;
                        }
                    case "жиза":
                        {
                            msg.Channel.SendMessageAsync($"чё, error on line 5854854");
                            Console.WriteLine($"{DateTime.Now}: {msg.Author} пишет ~жиза~");
                            break;
                        }
                    case "не обязан":
                        {
                            msg.Channel.SendMessageAsync($"обязан, я так сказал");
                            Console.WriteLine($"{DateTime.Now}: {msg.Author} пишет ~не обязан~");
                            break;
                        }
                    case "?как ты относишься к неграм":
                        {
                            /*msg.Channel.SendMessageAsync($"СОЛНЦЕ СВЕТИТ НЕГРЫ ПАШУТ");
                            System.Threading.Thread.Sleep(0010);
                            msg.Channel.SendMessageAsync($"ВОТ ТАКАЯ ДОЛЯ НАША");*/
                            //переделал 07.03.22
                            msg.Channel.SendMessageAsync("СОЛНЦЕ СВЕТИТ НЕГРЫ ПАШУТ\nВОТ ТАКАЯ ДОЛЯ НАША");
                            Console.WriteLine($"{DateTime.Now}: {msg.Author} использует комманду ?как ты относишься к неграм");
                            break;
                        }
                    case "!опиши 906847830960910338":
                        {
                            msg.Channel.SendMessageAsync($"это я");
                            System.Threading.Thread.Sleep(0010);
                            msg.Channel.SendMessageAsync($"я хороший");
                            Console.WriteLine($"{DateTime.Now}: {msg.Author} использует комманду !опиши 906847830960910338");
                            break;
                        }
                    case "?ты дед инсайд":
                        {
                            msg.Channel.SendMessageAsync($"у меня 465488485484 часов в доте");
                            System.Threading.Thread.Sleep(0010);
                            msg.Channel.SendMessageAsync($"я настоящий гуль zxc");
                            Console.WriteLine($"{DateTime.Now}: {msg.Author} использует комманду ?ты дед инсайд");
                            break;
                        }
                    case "?негры пидоры":
                        {
                            msg.Channel.SendMessageAsync($"ДААААААААААААААААА");
                            Console.WriteLine($"{DateTime.Now}: {msg.Author} использует комманду ?негры пидоры");
                            break;
                        }
                    case "?я одер":
                        {
                            msg.Channel.SendMessageAsync($"да");
                            Console.WriteLine($"{DateTime.Now}: {msg.Author} использует комманду ?я одер");
                            break;
                        }
                    case "?ты гей":
                        {
                            msg.Channel.SendMessageAsync($"нет");
                            Console.WriteLine($"{DateTime.Now}: {msg.Author} использует комманду ?ты гей");
                            break;
                        }
                    case "?ты бебра":
                        {
                            msg.Channel.SendMessageAsync($"я сусси бака импостор уву");
                            Console.WriteLine($"{DateTime.Now}: {msg.Author} использует комманду ?ты бебра");
                            break;
                        }
                    case "!скинь ножки":
                        {
                            msg.Channel.SendMessageAsync($"https://cdn.discordapp.com/attachments/870099010344607764/904312393264406558/IMG_1112.mp4");
                            Console.WriteLine($"{DateTime.Now}: {msg.Author} использует комманду !скинь ножки");
                            break;
                        }
                    case "!скинь ножки в чулках":
                        {
                            msg.Channel.SendMessageAsync($"https://cdn.discordapp.com/attachments/870099010344607764/904312393264406558/IMG_1112.mp4");
                            Console.WriteLine($"{DateTime.Now}: {msg.Author} использует комманду !скинь ножки в чулках");
                            break;
                        }
                    case "!покажи трусики":
                        {
                            msg.Channel.SendMessageAsync($"https://cdn.discordapp.com/attachments/870099010344607764/904312393264406558/IMG_1112.mp4");
                            Console.WriteLine($"{DateTime.Now}: {msg.Author} использует комманду !покажи трусики");
                            break;
                        }
                    case "?":
                        {
                            msg.Channel.SendMessageAsync($"На что я должен тебе ответить?, На воздух?");
                            Console.WriteLine($"{DateTime.Now}: {msg.Author} пишет ~?~");
                            break;
                        }
//опять моё                   
                    case "!ты бот":
                        {
                            msg.Channel.SendMessageAsync($"сам такой чел...");
                            Console.WriteLine($"{DateTime.Now}: {msg.Author} использует комманду !ты бот");
                            break;
                        }
                    case "?ты рассит":
                        {
                            msg.Channel.SendMessageAsync($"да");
                            Console.WriteLine($"{DateTime.Now}: {msg.Author} использует комманду ?ты рассит");
                            break;
                        }
                    case "!крутой":
                        {
                            msg.Channel.SendMessageAsync($"кто?");
                            Console.WriteLine($"{DateTime.Now}: {msg.Author} использует комманду !крутой");
                            break;
                        }
                    case "&ты":
                        {
                            msg.Channel.SendMessageAsync($"спасибо, +9999999 социальный кредит");
                            Console.WriteLine($"{DateTime.Now}: {msg.Author} использует комманду &ты");
                            break;
                        }
                    case "?есть леон":
                        {
                            msg.Channel.SendMessageAsync($"нет у меня леона");
                            Console.WriteLine($"{DateTime.Now}: {msg.Author} использует комманду ?есть леон");
                            break;
                        }
                    case "?забив":
                        {
                            msg.Channel.SendMessageAsync($"у кого?");
                            Console.WriteLine($"{msg.Author} использует комманду ?забив");
                            break;
                        }
                    case "&у тебя":
                        {
                            msg.Channel.SendMessageAsync($"1000-7");
                            Console.WriteLine($"{DateTime.Now}: {msg.Author} использует комманду &у тебя");
                            break;
                        }
                    case "?ты веган":
                        {
                            msg.Channel.SendMessageAsync($"я ем плохих людей");
                            Console.WriteLine($"{DateTime.Now}: {msg.Author} использует комманду ?ты веган");
                            break;
                        }
                    case "?негры плохие":
                        {
                            msg.Channel.SendMessageAsync($"ДАААААААААААААААААААААААААААААААААААААААА");
                            Console.WriteLine($"{DateTime.Now}: {msg.Author} использует комманду ?неры плохие");
                            break;
                        }
                    case "?Burger apk скид":
                        {
                            msg.Channel.SendMessageAsync($"ДА");
                            Console.WriteLine($"{DateTime.Now}: {msg.Author} использует комманду ?Burger apk скид");
                            break;
                        }
                    case "?сникерс или твикс":
                        {
                            msg.Channel.SendMessageAsync($"сниггерс");
                            Console.WriteLine($"{DateTime.Now}: {msg.Author} использует комманду ?сниккерс или твикс");
                            break;
                        }
                    case "?лучший":
                        {
                            msg.Channel.SendMessageAsync($"я?");
                            Console.WriteLine($"{DateTime.Now}: {msg.Author} использует комманду ?лучший");
                            break;
                        }
                    case "&да, ты":
                        {
                            msg.Channel.SendMessageAsync($"спасибо, +3 социальный кредит");
                            Console.WriteLine($"{DateTime.Now}: {msg.Author} использует комманду &да, ты");
                            break;
                        }
                    case "?го выпьем пива":
                        {
                            msg.Channel.SendMessageAsync($"го");
                            Console.WriteLine($"{DateTime.Now}: {msg.Author} использует комманду ?го выпьем пива");
                            break;
                        }
                    case "ахринел😡😡":
                        {
                            msg.Channel.SendMessageAsync($"ну да, а что?");
                            Console.WriteLine($"{DateTime.Now}: {msg.Author} пишет ~ахринел😡😡~");
                            break;
                        }
                    case "?красавчик":
                        {
                            msg.Channel.SendMessageAsync($"да");
                            Console.WriteLine($"{DateTime.Now}: {msg.Author} использует комманду ?красавчик");
                            break;
                        }
                    case "запрещаю":
                        {
                            msg.Channel.SendMessageAsync($"а я разрещаю");
                            Console.WriteLine($"{DateTime.Now}: {msg.Author} пишет ~запрещаю~");
                            break;
                        }
                    case "меня слили(":
                        {
                            msg.Channel.SendMessageAsync($"sussy baka impostor uwu#2115 on top, ez {msg.Author}");
                            Console.WriteLine($"{DateTime.Now}: {msg.Author} пишет ~меня слили(~");
                            break;
                        }
                    case "?из катка":
                        {
                            msg.Channel.SendMessageAsync($"что");
                            Console.WriteLine($"{DateTime.Now}: {msg.Author} использует комманду ?из катка");
                            break;
                        }
                    case "&то":
                        {
                            msg.Channel.SendMessageAsync($"слит");
                            Console.WriteLine($"{DateTime.Now}: {msg.Author} использует комманду &пишет");
                            break;
                        }
                    case "?я бот":
                        {
                            msg.Channel.SendMessageAsync($"нет, ты {msg.Author}");
                            Console.WriteLine($"{DateTime.Now}: {msg.Author} использует комманду ?я бот");
                            break;
                        }
                    case "&нет, не ты":
                        {
                            msg.Channel.SendMessageAsync($"-999 социальный кредит");
                            Console.WriteLine($"{DateTime.Now}: {msg.Author} использует комманду &нет, не ты");
                            break;
                        }
                    case "?брах":
                        {
                            msg.Channel.SendMessageAsync($"на что я должен тебе ответить?");
                            Console.WriteLine($"{DateTime.Now}: {msg.Author} использует комманду ?брах");
                            break;
                        }
                    case "?иди по спи":
                        {
                            msg.Channel.SendMessageAsync($"ты перепутал префикс");
                            Console.WriteLine($"{DateTime.Now}: {msg.Author} использует комманду ?иди по спи");
                            break;
                        }
                    case "!иди по спи":
                        {
                            msg.Channel.SendMessageAsync($"выключение: ..%");
                            System.Threading.Thread.Sleep(3000);
                            msg.Channel.SendMessageAsync($"выключение: 1%");
                            System.Threading.Thread.Sleep(0001);
                            msg.Channel.SendMessageAsync($"выключение: 55%");
                            System.Threading.Thread.Sleep(3000);
                            msg.Channel.SendMessageAsync($"выключение: 100%");
                            System.Threading.Thread.Sleep(0001);
                            msg.Channel.SendMessageAsync($"я сплю урааа");
                            //в v2 версии там ModifyAsync :)
                            Console.WriteLine($"{DateTime.Now}: {msg.Author} использует комманду !иди по спи");
                            break;
                        }
                    case "ты поспал бот?":
                        {
                            msg.Channel.SendMessageAsync($"нет, я rr34 смотрел");
                            Console.WriteLine($"{DateTime.Now}: {msg.Author} пишет ~ты поспал бот?~");
                            break;
                        }
                    case "?питон калл":
                        {
                            //msg.Channel.SendMessageAsync($"да, c++, c#, node.js, lua>>>>>>>>>python");
                            //переделал 06.03.22
                            msg.Channel.SendMessageAsync("да\nc++, c#, node.js, luau>python");
                            Console.WriteLine($"{DateTime.Now}: {msg.Author} использует комманду ?питон калл");
                            break;
                        }
                    case "я помню":
                        {
                            msg.Channel.SendMessageAsync($"что ты помнишь?");
                            Console.WriteLine($"{DateTime.Now}: {msg.Author} пишет ~я помню~");
                            break;
                        }
                    case "большой":
                        {
                            msg.Channel.SendMessageAsync($"что большой? Кран? Дом?");
                            Console.WriteLine($"{DateTime.Now}: {msg.Author} пишет ~большой~");
                            break;
                        }
                    case "@everyone":
                        {
                            msg.Channel.SendMessageAsync($"ЧЁ ВСЕХ ПИНГУЕШЬ😡😡");
                            Console.WriteLine($"{DateTime.Now}: {msg.Author} пингует");
                            break;
                        }
                    case "@here":
                        {
                            msg.Channel.SendMessageAsync($"что тут?");
                            Console.WriteLine($"{DateTime.Now}: {msg.Author} использует @here");
                            break;
                        }
                    case "какие комманды добавлять?":
                        {
                            msg.Channel.SendMessageAsync($"@everyone да, какие добавлять?");
                            Console.WriteLine($"{DateTime.Now}: {msg.Author} пишет ~какие комманды добавлять?~");
                            break;
                        }
                    case "?я раб овангота":
                        {
                            msg.Channel.SendMessageAsync($"да");
                            Console.WriteLine($"{DateTime.Now}: {msg.Author} спрашивает ?я раб овангота");
                            break;
                        }
                    case "?я дед инсайд":
                        {
                            msg.Channel.SendMessageAsync($"нет");
                            Console.WriteLine($"{DateTime.Now}: {msg.Author} использует комманду ?я дед инсайд");
                            break;
                        }
                    case "&у меня есть часы в доте":
                        {
                            msg.Channel.SendMessageAsync($"извеняюсь");
                            Console.WriteLine($"{DateTime.Now}: {msg.Author} использует комманду &у меня есть часы в доте");
                            break;
                        }
                    case "sbi:refresh":
                        {
                            msg.Channel.SendMessageAsync($"Бот обновлён");
                            Console.WriteLine($"{DateTime.Now}: {msg.Author} использует комманду sbi:refresh");
                            break;
                        }
                    case "sbi:off":
                        {
                            msg.Channel.SendMessageAsync($"ты чё, думаешь что я пойду спать? хаха, вот ты и поверил");
                            Console.WriteLine($"{DateTime.Now}: {msg.Author} подумал что sbi:off выключит бота");
                            break;
                        }
                    case "слит":
                        {
                            msg.Channel.SendMessageAsync($"я не слитый");
                            Console.WriteLine($"{DateTime.Now}: {msg.Author} пишет ~слит~");
                            break;
                        }
                    case "Пруфай ботяра слитый бот го один на один в баунти на кольтах":
                        {
                            msg.Channel.SendMessageAsync($"||выиграл тебя в соло||");
                            Console.WriteLine($"{DateTime.Now}: {msg.Author} пишет ~Пруфай ботяра слитый бот го один на один в баунти на кольтах~");
                            break;
                        }
                    case "я слит(":
                        {
                            msg.Channel.SendMessageAsync($"sussy baka impostor uwu#2115 on top, ez {msg.Author}");
                            Console.WriteLine($"{DateTime.Now}: {msg.Author} пишет ~я слит(~");
                            break;
                        }
                    case "!sussy baka impostor uwu":
                        {
                            msg.Channel.SendMessageAsync($"что надо, я rusmynth`а смотрю (iris топ тянка)");
                            Console.WriteLine($"{DateTime.Now}: {msg.Author} использует комманду !sussy baka impostor uwu");
                            break;
                        }
                    case "?ты бот":
                        {
                            msg.Channel.SendMessageAsync($"да");
                            Console.WriteLine($"{DateTime.Now}: {msg.Author} использует комманду ?ты бот");
                            break;
                        }
                    case "?ты эдгар":
                        {
                            msg.Channel.SendMessageAsync($"да");
                            Console.WriteLine($"{DateTime.Now}: {msg.Author} использует комманду ?ты эдгар");
                            break;
                        }
                    case "!LATIDADIDA":
                        {
                            msg.Channel.SendMessageAsync($"https://cdn.discordapp.com/attachments/886595182437470229/909383317667848252/e58736fb7853d392d9658d94cea0eaba.mp4");
                            Console.WriteLine($"{DateTime.Now}: {msg.Author} использует комманду !LATIDADIDA");
                            break;
                        }
                    case "я не про тебя даун":
                        {
                            msg.Channel.SendMessageAsync($"извени");
                            Console.WriteLine($"{DateTime.Now}: {msg.Author} пишет ~я не про тебя даун~");
                            break;
                        }
                    case "Я ненавижу товарища Xi":
                        {
                            /*msg.Channel.SendMessageAsync($"-999999 social credit");
                            System.Threading.Thread.Sleep(1000);
                            msg.Channel.SendMessageAsync($"execution date: 二○二一年十二月三日");*/
                            //переделал 06.03.22
                            msg.Channel.SendMessageAsync("-999999 social credit\nexecution date: 二○二一年十二月三日");
                            Console.WriteLine($"{DateTime.Now}: {msg.Author} пишет ~Я ненавижу товарища Xi~");
                            break;
                        }
                    case "?версия":
                        {
                            //msg.Channel.SendMessageAsync($"1.1.0");
                            //переделал 07.03.22
                            msg.Channel.SendMessageAsync($"sbi:v1.1.0O\nОбозначение версий саси баки:\n`D` ==> дебаг версия[на тестировании] (**D**ebug)\n`S` ==> стабильная, прошла аптайм 2 дня или больше (**S**table)\n`NS` ==> стабильная, но не прошла аптайм 2 дня или больше (**N**ot **S**table)\n`O` ==> устаревшая версия (**O**utdated)");
                            break;
                        }
                }
                    return Task.CompletedTask;
                }
        }
    }
