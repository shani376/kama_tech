﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using CoronaApp.Services.Models;

namespace CoronaApp.Dal;

public class MockDataPatient : IDalPatient
{
    public List<Patient> patients = new List<Patient>{
        new Patient{ Id="111111111",name="first",age=1},
        new Patient{ Id="222222222",name="second",age=2},
        new Patient{ Id="333333333",name="theared",age=3},
    };
    public async Task<List<Patient>> GetPatients()
    {
        return await Task.FromResult(patients);
    }

    public async Task<List<Patient>> getAllPatients()
    {
        return await GetPatients();
    }

    public void postPatient(Patient pat)
    {
        patients.Add(pat);
    }

}
