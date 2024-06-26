﻿using Core.Constants;

namespace Core.Requests;

public class CreateAccountRequest
{
    public string Holder { get; set; } = string.Empty;
    public string Number { get; set; } = string.Empty;
    public int CurrencyId { get; set; }
    public int CustomerId { get; set; }
    public AccountType AccountType { get; set; }
    public CreateSavingAccount? CreateSavingAccount { get; set; }
    public CreateCurrentAccount? CreateCurrentAccount { get; set; }
}
