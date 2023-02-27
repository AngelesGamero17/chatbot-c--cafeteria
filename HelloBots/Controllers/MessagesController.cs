using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Microsoft.Bot.Connector;
using Microsoft.Bot.Builder.Dialogs;
using System.Threading.Tasks;
using System.Diagnostics;

namespace HelloBots.Controllers
{
    [BotAuthentication]
    public class MessagesController : ApiController
    {
        public async Task<HttpResponseMessage> Post([FromBody] Activity activity)
        {
            if (activity.Type == ActivityTypes.Message)
            {
                await Conversation.SendAsync(activity, () => new Dialogs.MyDialog());
            }
            else
            {
                HandleSystemMessage(activity);
            }
            var Response = Request.CreateResponse(HttpStatusCode.OK);
            return Response;
        }
        void HandleSystemMessage(Activity message)
        {
            switch (message.Type)
            {
                case ActivityTypes.ConversationUpdate:
                    break;
                case ActivityTypes.ContactRelationUpdate:
                    break;
                case ActivityTypes.Typing:
                    break;
                case ActivityTypes.Ping:
                    break;
                case ActivityTypes.DeleteUserData:
                    break;
            }
        }
    }
}