namespace ClientDocGFS.Shared.Client;

public static class ClientRequest
{
    public class Index
    {
    //properties for firstStep
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string FirstNameParter { get; set; }
    public string LastnameParter { get; set; }
    public string AdressStreetName { get; set; }
    public int CityNumber { get; set; }
    public string CityName { get; set; }
    public string PhoneNumber { get; set; }
    public string MailAdress { get; set; }

    //properties for secondStep
    public string enterpriseNumber { get; set; } //ondernemingsnummer
    public string nationalNumber { get; set; } //rijskregister
    public short kids { get; set; }

    public override string ToString()
    {
        return
            $"{nameof(FirstName)}: {FirstName}, {nameof(LastName)}: {LastName}, {nameof(FirstNameParter)}: {FirstNameParter}, {nameof(LastnameParter)}: {LastnameParter}, {nameof(AdressStreetName)}: {AdressStreetName}, {nameof(CityNumber)}: {CityNumber}, {nameof(CityName)}: {CityName}, {nameof(PhoneNumber)}: {PhoneNumber}, {nameof(MailAdress)}: {MailAdress}, {nameof(enterpriseNumber)}: {enterpriseNumber}, {nameof(nationalNumber)}: {nationalNumber}, {nameof(kids)}: {kids}, {nameof(bankNumber)}: {bankNumber}, {nameof(bankNumberOtherCountry)}: {bankNumberOtherCountry}";
    }

    public string bankNumber { get; set; }
    public string bankNumberOtherCountry { get; set; }
    }
    public class Create
    {
    //properties for firstStep
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string FirstNameParter { get; set; }
    public string LastnameParter { get; set; }
    public string AdressStreetName { get; set; }
    public int CityNumber { get; set; }
    public string CityName { get; set; }
    public string PhoneNumber { get; set; }
    public string MailAdress { get; set; }

    //properties for secondStep
    public string enterpriseNumber { get; set; } //ondernemingsnummer
    public string nationalNumber { get; set; } //rijskregister
    public short kids { get; set; }

    public override string ToString()
    {
        return
            $"{nameof(FirstName)}: {FirstName}, {nameof(LastName)}: {LastName}, {nameof(FirstNameParter)}: {FirstNameParter}, {nameof(LastnameParter)}: {LastnameParter}, {nameof(AdressStreetName)}: {AdressStreetName}, {nameof(CityNumber)}: {CityNumber}, {nameof(CityName)}: {CityName}, {nameof(PhoneNumber)}: {PhoneNumber}, {nameof(MailAdress)}: {MailAdress}, {nameof(enterpriseNumber)}: {enterpriseNumber}, {nameof(nationalNumber)}: {nationalNumber}, {nameof(kids)}: {kids}, {nameof(bankNumber)}: {bankNumber}, {nameof(bankNumberOtherCountry)}: {bankNumberOtherCountry}";
    }

    public string bankNumber { get; set; }
    public string bankNumberOtherCountry { get; set; }
    }
}