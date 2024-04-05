﻿using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;

namespace KudrPDP
{
    public class BaseWindow : Window
    {
        public BaseWindow()
        {
            Loaded += BaseWindow_Loaded;
        }

        private void BaseWindow_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void Collapse_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите закрыть окно?", "Подтверждение", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                Application.Current.Shutdown();
            }
        }

        private void BackTo(object sender, RoutedEventArgs e)
        {
            /* Look, if you had one shot, or one opportunity
            To seize everything you ever wanted-One moment
            Would you capture it or just let it slip?

            His palms are sweaty, knees weak, arms are heavy
            There's vomit on his sweater already, mom's spaghetti
            He's nervous, but on the surface he looks calm and ready
            To drop bombs, but he keeps on forgettin
            What he wrote down, the whole crowd goes so loud
            He opens his mouth, but the words won't come out
            He's chokin, how everybody's jokin now
            The clock's run out, time's up over, bloah!
            Snap back to reality, Oh there goes gravity
            Oh, there goes Rabbit, he choked
            He's so mad, but he won't give up that
            Easy, no
            He won't have it , he knows his whole back's to these ropes
            It don't matter, he's dope
            He knows that, but he's broke
            He's so stagnant that he knows
            When he goes back to his mobile home, that's when it's
            Back to the lab again yo
            This whole rap shit
            He better go capture this moment and hope it don't pass him

            You better lose yourself in the music, the moment
            You own it, you better never let it go
            You only get one shot, do not miss your chance to blow
            This opportunity comes once in a lifetime yo

            The soul's escaping, through this hole that it's gaping
            This world is mine for the taking
            Make me king, as we move toward a, new world order
            A normal life is borin, but superstardom's close to post mortem
            It only grows harder, only grows hotter
            He blows us all over these hoes is all on him
            Coast to coast shows, he's know as the globetrotter
            Lonely roads, God only knows
            He's grown farther from home, he's no father
            He goes home and barely knows his own daughter
            But hold your nose cuz here goes the cold water
            His hoes don't want him no mo, he's cold product
            They moved on to the next schmoe who flows
            He nose dove and sold nada
            So the soap opera is told and unfolds
            I suppose it's old partna', but the beat goes on
            Da da dum da dum da da

            No more games, I'ma change what you call rage
            Tear this mothafuckin roof off like 2 dogs caged
            I was playin in the beginnin, the mood all changed
            I been chewed up and spit out and booed off stage
            But I kept rhymin and stepwritin the next cypher
            Best believe somebody's payin the pied piper
            All the pain inside amplified by the fact
            That I can't get by with my 9 to 5
            And I can't provide the right type of life for my family
            Cuz man, these goddam food stamps don't buy diapers
            And it's no movie, there's no Mekhi Phifer, this is my life
            And these times are so hard and it's getting even harder
            Tryin to feed and water my seed, plus
            See dishonor caught up between being a father and a prima donna
            Baby mama drama's screamin on and
            Too much for me to wanna
            Stay in one spot, another day of monotony
            Has gotten me to the point, I'm like a snail
            I've got to formulate a plot fore I end up in jail or shot
            Success is my only mothafuckin option, failure's not
            Mom, I love you, but this trailer's got to go
            I cannot grow old in Salem's lot
            So here I go is my shot.
            Feet fail me not cuz maybe the only opportunity that I got */
        }
    }
}