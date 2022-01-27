// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

BankingConfig.Cashier cashier = new BankingConfig.Cashier();
cashier.Deposit_withdraw();
cashier = new BankingConfig.Customer();
cashier.Deposit_withdraw();
cashier = new BankingConfig.Customer1();
cashier.Deposit_withdraw();
