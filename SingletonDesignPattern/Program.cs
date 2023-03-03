using System;
using SingletonDesignPattern;
Thread t1 = new Thread(() =>
 {
     var instance = UploadServices.Instance();
     Console.WriteLine(instance);
 });
Thread t2 = new Thread(() =>
{
    var instance = UploadServices.Instance();
    Console.WriteLine(instance);
});

t1.Start();
t2.Start();

t1.Join();
t2.Join();