using CS_HW_10;
using System.Threading;
using System.Threading.Tasks;


// 1
FirstTask.Init();
// 2
await SecondTask.DownloadDataAsync("https://lms.ithillel.ua/groups/6602b48e07612845e30e4a5c/homeworks/66cdd4567506a6d8c16cf449", "SavedData.txt");

