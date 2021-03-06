﻿using HostLists.Entities;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace HostmanUI.ViewModels
{
    [ImplementPropertyChanged]
    public class ProfileEditViewModel
    {

        public Profile Profile { get; private set; }

        public ProfileEditViewModel(Profile profile)
        {
            this.Profile = profile;
        }

        public List<HostEntry> ProfileHostList 
        { 
            get { return HostLists.HostLists.GetHostListForProfileId(Profile.RecordId); } 
        }
    }
}
