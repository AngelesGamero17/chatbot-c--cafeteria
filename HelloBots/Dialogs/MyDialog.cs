using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Connector;
using System.Threading.Tasks;

namespace HelloBots.Dialogs
{
    [Serializable]
    public class MyDialog:IDialog<string>
    {
        public async Task StartAsync(IDialogContext context)
        {
            context.Wait(MessageReceivedAsync);
        }
        private async Task MessageReceivedAsync(IDialogContext context, IAwaitable<object> result)
        {
            var activity = await result as Activity;
            var ActivityMessage = await result as Activity;
            int length = (activity.Text ?? string.Empty).Length;
            var Message = ActivityMessage.Text;
            //await context.PostAsync($"Tu enviaste:{activity.Text} con{length} caracteres.");
            // context.Wait(MessageReceivedAsync);
            string respuesta = "";
            if (activity.Text == "hola") { respuesta = "hola,que tal"; } else { respuesta = "Disculpa , no le entiendo"; }
            if (activity.Text == "Hola como vas") { respuesta = "hola, que tal !muy bien"; }
            if(activity.Text == "HOLA") { respuesta = "hola, que tal !muy bien"; }
            if (activity.Text == "Hola") { respuesta = "hola, que tal !muy bien"; }
            if (activity.Text == "hi") { respuesta = "hola, que tal !muy bien"; }
            if(activity.Text == "Hi") { respuesta = "hola, que tal !muy bien"; }
            if (activity.Text == "HI") { respuesta = "hola, que tal !muy bien"; }
            if (activity.Text == "Hello") { respuesta = "hola, que tal !muy bien"; }
            if (activity.Text == "hello") { respuesta = "hola, que tal !muy bien"; }
            if (activity.Text == "HELLO") { respuesta = "hola, que tal !muy bien"; }
            if (activity.Text == "ola") { respuesta = "hola, que tal !muy bien"; }
            if (activity.Text == "Buenas") { respuesta = "Buen dia , digame como le podemos ayudar"; }
            if (activity.Text == "Buenos dias") { respuesta = "Buen dia , digame como le podemos ayudar"; }
            if (activity.Text == "buenos dias") { respuesta = "Buen dia , digame como le podemos ayudar"; }
            if (activity.Text == "Buenos Dias") { respuesta = "Buen dia , digame como le podemos ayudar"; }
            if (activity.Text == "Buenas tardes") { respuesta = "Buenas tardes , digame como le podemos ayudar"; }
            if (activity.Text == "Buenas Tardes") { respuesta = "Buenas tardes , digame como le podemos ayudar"; }
            if (activity.Text == "buenas tardes") { respuesta = "Buenas tardes , digame como le podemos ayudar"; }
            if (activity.Text == "Buenas noches") { respuesta = "Buenas noches , Digame como le podemos ayudar"; }
            if (activity.Text == "Buenas Noches") { respuesta = "Buenas noches , Digame como le podemos ayudar"; }
            if (activity.Text == "buenas noches") { respuesta = "Buenas noches , Digame como le podemos ayudar"; }
            if (activity.Text == "Que tipo de Zapatillas tiene") { respuesta = "Ofrecemos todo tipo de zapatillas , podria mandarnos una foto de referencia de como la quiere"; }
            if(activity.Text == "Tiene Zapatillas en la talla 26?") { respuesta = "si tenemos todas las tallas disponibles"; }
            if (activity.Text == "tiene Zapatillas en la talla 26?") { respuesta = "si tenemos todas las tallas disponibles"; }
            if (activity.Text == "que tallas de zapatilla tiene disponible") { respuesta = "si tenemos todas las tallas disponibles"; }
            if (activity.Text == "Que tallas de zapatilla tiene") { respuesta = "si tenemos todas las tallas disponibles"; }
            if (activity.Text == "Tiene Zapatillas en la talla 25?") { respuesta = "si tenemos todas las tallas disponibles"; }
            if (activity.Text == "tiene zapatillas en la talla 25?") { respuesta = "si tenemos todas las tallas disponibles"; }
            if (activity.Text == "Tienes en la marca Bata") { respuesta = "Si tenemos en todas las marcas"; }
            if (activity.Text == "que marcas de zapatillas tiene?") { respuesta = "Si tenemos en todas las tallas"; }
            if (activity.Text == "que marcas de zapatillas tiene") { respuesta = "Si tenemos en todas las tallas"; }
            if (activity.Text == "Que marcas de zapatillas tiene?") { respuesta = "Si tenemos en todas las tallas"; }
            if (activity.Text == "Tienes en la marca adidas") { respuesta = "Si tenemos en todas las marcas"; }
            if (activity.Text == "tienes en la marca adidas") { respuesta = "Si tenemos en todas las marcas"; }
            if (activity.Text == "Tiene la zapatilla en color rojo") { respuesta = "si , tenemos todos los colores"; }
            if (activity.Text == "Tiene la zapatilla en color azul") { respuesta = "si , tenemos todos los colores"; }
            if (activity.Text == "Tiene la zapatilla en color negro") { respuesta = "si , tenemos todos los colores"; }
            if (activity.Text == "Tiene Zapatillas para niños") { respuesta = "si tenemos zapatillas para niños"; }
            if (activity.Text == "haces delivery?") { respuesta = "no lo sentimos , no hacemos delivey"; }
            if (activity.Text == "en donde se ubican?") { respuesta = "en el centro"; }
            if (activity.Text == "En donde se encuentra su tienda") { respuesta = "En el centro , puede ver nuestra pàgina"; }
            if (activity.Text == "cual es su ubicacion") { respuesta = "en nuestra pagina esta , nuestro croquis"; }
            if (activity.Text == "donde los puedo encontrar") { respuesta = "en nuestra tienda oficial en el centro , revice nuestra pagina oficial"; }
            if (activity.Text == "gracias") { respuesta = "Gracias a usted, vuelva pronto"; }
            if (activity.Text == "Gracias") { respuesta = "Gracias a usted, vuelva pronto"; }
            if (activity.Text == "Gracias") { respuesta = "Gracias a usted, vuelva pronto"; }
            if (activity.Text == "ok") { respuesta = "cualquier consulta o duda , haganos saber"; }
            if (activity.Text == "OK") { respuesta = "cualquier consulta o duda , haganos saber"; }
            if (activity.Text == "oK") { respuesta = "cualquier consulta o duda , haganos saber"; }
            if (activity.Text == "okey") { respuesta = "cualquier consulta o duda , haganos saber"; }
            if (activity.Text == "OKEY") { respuesta = "cualquier consulta o duda , haganos saber"; }
            if (activity.Text == "Okey") { respuesta = "cualquier consulta o duda , haganos saber"; }
            if (activity.Text == "chau") { respuesta = "hasta luego"; }
            if (activity.Text == "Chau") { respuesta = "hasta luego"; }
            if (activity.Text == "CHAU") { respuesta = "hasta luego"; }
            if (activity.Text == "Bye") { respuesta = "hasta luego"; }
            if (activity.Text == "BYE") { respuesta = "hasta luego"; }
            if (activity.Text == "bye") { respuesta = "hasta luego"; }

            await context.PostAsync(respuesta);
            
           
        }

    }
}