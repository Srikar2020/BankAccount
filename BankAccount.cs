public class AccountHolder
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime DateofBirth { get; set; }
    public string Email { get; set; }
    public int AccountHolderId {get; set; }
    public List<BankAccount> BankAccounts { get; set; }
    
}

public class BankAccount
{
    public string AccountNumber { get; set; }
    public decimal CurrentBalance { get; set; }
    public string AccountName { get; set; }
    public DateTime CreatedDate { get; set; }
    public string AccountType { get; set; }
    public int AccountHolderId { get; set; }
    public AccountHolder AccountHolder { get; set; }
    
}

public class Candidate
{
    public int CandidateId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public int JobTitleId { get; set; }
    public JobTitle JobTitle { get; set; }
    
}

public class Company
{
    public int CompanyId { get; set; }
    public string Name { get; set; }
    public string Location { get; set; }
    public string Industry { get; set; }
    public List<JobTitle> JobTitle { get; set; }
    
}

public class JobTitle
{
    public int JobTitleId { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public int CompanyId { get; set; }
    public Company Company { get; set; }
    
}

public class Industry
{
    public int IndustryId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public List<Company> Company { get; set; }
    
}
