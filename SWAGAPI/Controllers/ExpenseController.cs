using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SWAGAPI.Data;
using SWAGAPI.Models;

namespace SWAGAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExpenseController : ControllerBase
    {
        private readonly AppDbContext context;

        public ExpenseController(AppDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetExpenses()
        {
            var expenses = await context.Expenses.OrderBy(s => s.expenseId).Take(20).ToListAsync();
            return Ok(expenses);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetExpense(int id)
        {
            var expense = await context.Expenses.FindAsync(id);

            if (expense == null)
            {
                return NotFound();
            }

            return Ok(expense);
        }

        [HttpPost]
        public async Task<IActionResult> AddExpense(Expense expense)
        {
            context.Expenses.Add(expense);
            await context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetExpense), new { id = expense.expenseId }, expense);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateExpense(int id, Expense expense)
        {
            if (id != expense.expenseId)
            {
                return BadRequest();
            }

            context.Entry(expense).State = EntityState.Modified;

            try
            {
                await context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                var expenseExists = context.Expenses.Any(e => e.expenseId == id);

                if (!expenseExists)
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteExpense(int id)
        {
            var expense = await context.Expenses.FindAsync(id);

            if (expense == null)
            {
                return NotFound();
            }

            context.Expenses.Remove(expense);
            await context.SaveChangesAsync();

            return NoContent();
        }
    }
}
