﻿using System;
using GamerAddict.DAL.Data;
using GamerAddict.DAL.Interfaces.Repositories;
using GamerAddict.Domain.Entity;
using Microsoft.EntityFrameworkCore;

namespace GamerAddict.DAL.Repositories
{
	public class QuestionRepository : IQuestionRepository
	{
        private readonly ApplicationDbContext _context;

        public QuestionRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Question> Add(Question ItemToAdd)
        {
            await _context.Questions.AddAsync(ItemToAdd);
            await _context.SaveChangesAsync();
            return ItemToAdd;
        }

        public async Task<Question> Delete(int id)
        {
            var item = await _context.Questions.FirstOrDefaultAsync(x => x.Id == id);
            _context.Questions.Remove(item);
            await _context.SaveChangesAsync();

            return item;
        }

        public async Task<IEnumerable<Question>> GetAll()
        {
            return await _context.Questions.ToListAsync();
        }

        public async Task<Question> GetById(int id)
        {
            var item = await _context.Questions.FirstOrDefaultAsync(x => x.Id == id);
            return item;
        }

        public Task<Question> Update(Question ItemToUpdate)
        {
            throw new NotImplementedException();
        }
    }
}

