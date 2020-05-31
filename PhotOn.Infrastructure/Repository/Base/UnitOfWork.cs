﻿using PhotOn.Core.Repositories;
using PhotOn.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PhotOn.Infrastructure.Repository.Base
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly PhotOnContext _db;
        private  IPublicationRepository _publicatonRepository;
        private ITagRepository _tagRepository;
        private IEquipmentRepository _equipmentRepository;
        public UnitOfWork(PhotOnContext db)
        {
            _db = db;
        }

        public IPublicationRepository PublicatonRepository
        {
            get { return _publicatonRepository = _publicatonRepository ?? new PublicationRepository(_db); }
        }

        public ITagRepository TagRepository 
        { 
            get { return _tagRepository = _tagRepository ?? new TagRepository(_db); }

        }

        public IEquipmentRepository EquipmentRepository => throw new NotImplementedException();

        //public IUserRepository UserRepository
        //{
        //    get { return _userRepository = _userRepository ?? new UserRepository(_db); }
        //}

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
