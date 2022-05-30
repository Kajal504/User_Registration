// See https://aka.ms/new-console-template for more information
using User_Registration;
Console.WriteLine("Welcome to Program for User Registration");

UserRegistration UserRegistration = new UserRegistration();

Console.WriteLine(UserRegistration.ValidateFirstName("Kajal"));

Console.WriteLine(UserRegistration.ValidateLastName("Shendage"));

Console.WriteLine(UserRegistration.ValidateEmail("kajal123@gmail.com"));

Console.WriteLine(UserRegistration.ValidatePhoneNumber("+91 9924156412"));

Console.WriteLine(UserRegistration.ValidatePassword("Zxcvbnmas"));

Console.WriteLine(UserRegistration.ValidatePassword2("Zmcnhdas")); 

Console.WriteLine(UserRegistration.ValidatePassword3("1Zmxnchasd"));

Console.WriteLine(UserRegistration.ValidatePassword4("Z1xxccxv@"));


