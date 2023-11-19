using System;

namespace Valorant_Datahub
{
    public static class EventManager
    {
        public delegate void SubFormClosingHandler(object source, EventArgs e);
        public static event SubFormClosingHandler SubFormClosing;
        public static void TriggerClosingEvent(object sender,EventArgs e)
        {
            if(SubFormClosing!= null)
            {
                SubFormClosing(sender, e);
            }
        }

    }
    
}