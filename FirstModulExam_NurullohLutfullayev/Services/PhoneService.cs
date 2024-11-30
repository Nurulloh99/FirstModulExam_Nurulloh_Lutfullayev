using FirstModulExam_NurullohLutfullayev.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstModulExam_NurullohLutfullayev.Services;

public class PhoneService
{
    private static List<Phone> phones;

    public PhoneService()
    {
        phones = new List<Phone>();
    }

    public static Phone AddPhone(Phone phone)
    {
        phone.Id = Guid.NewGuid();
        phones.Add(phone);

        return phone;
    }


    public static Phone GetById(Guid phoneId)
    {
        foreach(var phone in phones)
        {
            if(phone.Id == phoneId)
            {
                return phone;
            }
        }
        return null;
    }


    public static bool DeletePhone(Guid phoneId)
    {
        var foundPhone = GetById(phoneId);

        if(foundPhone is null)
        {
            return false;
        }

        phones.Remove(foundPhone);
        return true;
    }


    public static bool UpdatePhone(Guid phoneId, Phone phone)
    {
        var foundPhone = GetById(phoneId);

        if(foundPhone is null)
        {
            return false;
        }

        var index = phones.IndexOf(foundPhone);
        phones[index] = phone;
        return true;
    }


    public static List<Phone> GetAllPhones()
    {
        return phones;
    }
}
