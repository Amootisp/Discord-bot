using System;
using System.Threading.Tasks;
using Discord.Commands;

namespace Discord_bot.Commands
{
    public class MultiplikationModule : ModuleBase<SocketCommandContext>
    {
        [Command("Multiplikation")]
        [Summary("Multiples numbers")]

        public Task SayAsync([Remainder] [Summary("Multiples numbers")] string expression)
        {
            string[] arrayexpression = new String[] {"22", "22"};
            string product = null;
            try
            { 
                arrayexpression = expression.ToLower().Split('*');
                int expressionright = Convert.ToInt16(arrayexpression[0]);
                int expressionleft = Convert.ToInt16(arrayexpression[1]);
                int Result = expressionleft * expressionright;
                product = Convert.ToString(Result);
                
                
            }
            catch (Exception)
            {
                string fail = "No spaces, only numbers and * required for multiplikation";
                return ReplyAsync(fail);
            }

            return ReplyAsync(product);
        }
    }
}