﻿

using ConsoleApp14;

string a = SpesialOffers.ReadFromConsoleClientName();
int b = SpesialOffers.ReadFromConsoleAge();
int c = SpesialOffers.ReadFromConsoleService();
int d = SpesialOffers.ReadFromConsoleSum();
int m = SpesialOffers.CheckingValue(b, c, d);

SpesialOffers.WriteResult(a, m);


int e = BankDeposit.ReadFromConsoleAmount();
int f = BankDeposit.ReadFromConsoleYear();
int g = BankDeposit.ReadFromConsolePercent();

int h = BankDeposit.CoutingSaving(e, f, g);
BankDeposit.WriteResult(h);


int i = CoutingBanknotes.ReadFromConsole();
int j = CoutingBanknotes.CountResult(i);
CoutingBanknotes.WriteResult(j);
