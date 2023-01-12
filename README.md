# Codecademy-C-Projects
This is in preparation for the OSEP. The OSEP heavily relies on C# for writing custom shellcode runners and different bypasses. 

The first project is: Console_Creatures.cs. The project revolved around creating ASCII art, which is useful in learning how to create cool bannners for programs. Banners are obviously the most important part of a program. Morever, gets you used to the Console.WriteLine command. 

The second program that is not actually part of a project is useful. It teaches you that Console.ReadLine will always return a string. Therefore, it is important that once the string is returned and a function is expecting an interger, you gotta covert it using Convert.ToInt32. Actually, if we take a process injection program for example, the "CreateRemoteThread" function requires the Process ID of a task in Windows. The process ID is an interger. If we want to ask the user to specify the ID of the process we want to inject shellcode into, we would need to convert it to an interger from a string. This is why this program is useful. 

The third program introduces how to work with text and variables. This is useful because now we have learned different methods such as .Length, which calculates the character length of a string. Morever, it also teaches you about working with new lines. 

The fourth program introduces functions and the different arguments that are needed for functions to run. This is extremely importan when invoking different APIs and understanding whatever arguments they need.
