using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trener
{

    public static class AllStrikes
    {


        public static PunchClass jab = new PunchClass("Jab", "1", @"Sounds\punches\1-sound.mp3");
        public static PunchClass cross = new PunchClass("Cross", "2", @"Sounds\punches\2-sound.mp3");
        public static PunchClass lead_hook = new PunchClass("Lead hook", "3", @"Sounds\punches\3-sound.mp3");
        public static PunchClass rear_hook = new PunchClass("Rear hook", "4", @"Sounds\punches\4-sound.mp3");
        public static PunchClass lead_upper = new PunchClass("Lead uppercut", "5", @"Sounds\punches\5-sound.mp3");
        public static PunchClass rear_upper = new PunchClass("Rear uppercut", "6", @"Sounds\punches\6-sound.mp3");

        public static PunchClass jab_b = new PunchClass("Body jab", "1b", @"Sounds\punches\1b-sound.mp3");
        public static PunchClass cross_b = new PunchClass("Body cross", "2b", @"Sounds\punches\2b-sound.mp3");
        public static PunchClass lead_hook_b = new PunchClass("Lead body hook ", "3b", @"Sounds\punches\3b-sound.mp3");
        public static PunchClass rear_hook_b = new PunchClass("Rear body hook", "4b", @"Sounds\punches\4b-sound.mp3");
        public static PunchClass lead_upper_b = new PunchClass("Lead body uppercut", "5b", @"Sounds\punches\5b-sound.mp3");
        public static PunchClass rear_upper_b = new PunchClass("Rear body uppercut", "6b", @"Sounds\punches\6b-sound.mp3");



        public static class AllAdvice
        {
            public static AdviceClass hands_high = new AdviceClass( "Hands high", @"Sounds\tips\hands high-sound.mp3");

            public static AdviceClass basic_strikes_intro = new AdviceClass( "Single punches now", @"Sounds\workout_specific\intro-sound.mp3");
            public static AdviceClass two_p_combos = new AdviceClass("2p combos now", @"Sounds\workout_specific\2p-sound.mp3");

            public static AdviceClass three_p_combos = new AdviceClass("3p combos now", @"Sounds\workout_specific\3punchcombos-sound.mp3");
            public static AdviceClass three_p_combos_movement = new AdviceClass( "3p combos with movement now", @"Sounds\workout_specific\3punchcomboswithmovement-sound.mp3");
            public static AdviceClass three_p_combos_defence = new AdviceClass( "3p combos with defence now", @"Sounds\workout_specific\3punchcomboswithdefence-sound.mp3");


            public static AdviceClass defence_only = new AdviceClass( "Defence only", @"Sounds\workout_specific\basic_defence_intro-sound.mp3");
            public static AdviceClass add_counters = new AdviceClass( "Add counters", @"Sounds\workout_specific\basic_defence_counters-sound.mp3");

            public static AdviceClass move_only = new AdviceClass("Movement only", @"Sounds\workout_specific\basic_movement_intro-sound.mp3");
            public static AdviceClass combos_after_moves = new AdviceClass( "Add combos after moves", @"Sounds\workout_specific\basic_movement_combos-sound.mp3");
            public static AdviceClass mix_it_up = new AdviceClass( "Mix it up", @"Sounds\workout_specific\basic_all-sound.mp3");


            public static AdviceClass headmovement_only = new AdviceClass( "Headmovement only", @"Sounds\workout_specific\headmovementonly-sound.mp3");



            public static AdviceClass moveyourhead = new AdviceClass("Move your head", @"Sounds\tips\moveyourhead-sound.mp3");
            public static AdviceClass switchstance = new AdviceClass( "Switch your stance", @"Sounds\tips\switchstance-sound.mp3");
            public static AdviceClass highguard = new AdviceClass( "Highguard up", @"Sounds\tips\highguard-sound.mp3");
            public static AdviceClass keepmoving = new AdviceClass( "Keep moving", @"Sounds\tips\keepmoving-sound.mp3");




        }
        public static class AllDefence
        {
            /* HEADMOVEMENT*/
            public static DefenceClass r_slip = new DefenceClass("Rear slip", "RSlip", @"Sounds\defence\r_slip-sound.mp3");
            public static DefenceClass l_slip = new DefenceClass("Lead slip", "LSlip", @"Sounds\defence\l_slip-sound.mp3");
            public static DefenceClass pull = new DefenceClass("Pull", "Pull", @"Sounds\defence\pull-sound.mp3");
            public static DefenceClass l_roll = new DefenceClass("Lead roll", "LRoll", @"Sounds\defence\l_roll-sound.mp3");
            public static DefenceClass r_roll = new DefenceClass("Rear roll", "RRoll", @"Sounds\defence\r_roll-sound.mp3");
            public static DefenceClass duck = new DefenceClass("Duck", "Duck", @"Sounds\defence\duck-sound.mp3");



            /* BLOK */
            public static DefenceClass l_catch = new DefenceClass("Lead catch", "LCatch", @"Sounds\defence\l_catch-sound.mp3");
            public static DefenceClass r_catch = new DefenceClass("Rear catch", "RCatch", @"Sounds\defence\r_catch-sound.mp3");
            public static DefenceClass l_parry = new DefenceClass("Lead parry", "LParry", @"Sounds\defence\l_parry-sound.mp3");
            public static DefenceClass r_parry = new DefenceClass("Rear parry", "RParry", @"Sounds\defence\r_parry-sound.mp3");

            /* BODY*/
            public static DefenceClass bodyblock = new DefenceClass("Bodyblock", "BBlock", @"Sounds\defence\bodyblock-sound.mp3");
            public static DefenceClass r_bodyblock = new DefenceClass("Rear bodyblock", "RBBlock", @"Sounds\defence\r_bodyblock-sound.mp3");
            public static DefenceClass l_bodyblock = new DefenceClass("Lead bodyblock", "LBBlock", @"Sounds\defence\l_bodyblock-sound.mp3");


            /*shoulder roll*/
            public static DefenceClass s_roll = new DefenceClass("Shoulder roll", "SRoll", @"Sounds\defence\s_roll-sound.mp3");


        }
        public static class AllMovements
        {
            /* steps */
            public static MoveClass step_right = new MoveClass("Step right", "StepR", @"Sounds\movements\step_right-sound.mp3");
            public static MoveClass step_left = new MoveClass("Step left", "StepL", @"Sounds\movements\step_left-sound.mp3");
            public static MoveClass step_back = new MoveClass("Step back", "StepB", @"Sounds\movements\step_back-sound.mp3");
            public static MoveClass step_forward = new MoveClass("Step forward", "StepF", @"Sounds\movements\step_forward-sound.mp3");

            /*pivots*/
            public static MoveClass i_sidestep = new MoveClass("Inside sidestep", "ISStep", @"Sounds\movements\i_sidestep-sound.mp3");
            public static MoveClass o_sidestep = new MoveClass("Outside sidestep", "OSStep", @"Sounds\movements\o_sidestep-sound.mp3");



        }
        public static class AllExercises
        {
            public static ExerciseClass pushups = new ExerciseClass("Pushups", "Pushups", @"Sounds\exercises\pushups-sound.mp3");
            public static ExerciseClass burpees = new ExerciseClass("Burpees", "Burpees", @"Sounds\exercises\burpees-sound.mp3");
            public static ExerciseClass squats = new ExerciseClass("Squats", "Squats", @"Sounds\exercises\squats-sound.mp3");
            public static ExerciseClass situps = new ExerciseClass("Situps", "Situps", @"Sounds\exercises\situps-sound.mp3");


            public static ExerciseClass shadowboxing = new ExerciseClass("Shadowboxing", "Shadowboxing", @"Sounds\exercises\shadowboxing-sound.mp3");
            public static ExerciseClass skippingrope = new ExerciseClass("Skipping rope", "Skipping rope", @"Sounds\exercises\skippingrope-sound.mp3");
            public static ExerciseClass plank = new ExerciseClass("Plank", "Plank", @"Sounds\exercises\plank-sound.mp3");


        }



    }
    public static class AllCombos
    {
        public static class CombosBuilder
        {



            public static class Combo1
            {
                //UPRAV ČASY
                public static ComboClass c_1 = new ComboClass(new List<IStrike> { AllStrikes.jab }, 1, 0, 0);

                public static ComboClass c_1_ls = new ComboClass(new List<IStrike> { AllStrikes.jab, AllStrikes.AllDefence.l_slip }, 1, 0, 0);

                public static ComboClass c_1_ls_1 = new ComboClass(new List<IStrike> { AllStrikes.jab, AllStrikes.AllDefence.l_slip, AllStrikes.jab }, 1, 0, 0);

                public static ComboClass c_1_ls_1_2 = new ComboClass(new List<IStrike> { AllStrikes.jab, AllStrikes.AllDefence.l_slip, AllStrikes.jab, AllStrikes.cross }, 1, 0, 0);

                public static ComboClass c_1_ls_1_2_rs = new ComboClass(new List<IStrike> { AllStrikes.jab, AllStrikes.AllDefence.l_slip, AllStrikes.jab, AllStrikes.cross, AllStrikes.AllDefence.r_slip }, 1, 0, 0);
                public static ComboClass c_1_ls_1_2_rs_2 = new ComboClass(new List<IStrike> { AllStrikes.jab, AllStrikes.AllDefence.l_slip, AllStrikes.jab, AllStrikes.cross, AllStrikes.AllDefence.r_slip, AllStrikes.cross }, 1, 0, 0);
                public static ComboClass c_1_ls_1_2_rs_2_3 = new ComboClass(new List<IStrike> { AllStrikes.jab, AllStrikes.AllDefence.l_slip, AllStrikes.jab, AllStrikes.cross, AllStrikes.AllDefence.r_slip, AllStrikes.cross, AllStrikes.lead_hook }, 1, 0, 0);
                public static ComboClass c_1_ls_1_2_rs_2_3_ls = new ComboClass(new List<IStrike> { AllStrikes.jab, AllStrikes.AllDefence.l_slip, AllStrikes.jab, AllStrikes.cross, AllStrikes.AllDefence.r_slip, AllStrikes.cross, AllStrikes.lead_hook, AllStrikes.AllDefence.l_slip }, 1, 0, 0);
                public static ComboClass c_1_ls_1_2_rs_2_3_ls_3 = new ComboClass(new List<IStrike> { AllStrikes.jab, AllStrikes.AllDefence.l_slip, AllStrikes.jab, AllStrikes.cross, AllStrikes.AllDefence.r_slip, AllStrikes.cross, AllStrikes.lead_hook, AllStrikes.AllDefence.l_slip, AllStrikes.lead_hook }, 1, 0, 0);
                public static ComboClass c_1_ls_1_2_rs_2_3_ls_3_2 = new ComboClass(new List<IStrike> { AllStrikes.jab, AllStrikes.AllDefence.l_slip, AllStrikes.jab, AllStrikes.cross, AllStrikes.AllDefence.r_slip, AllStrikes.cross, AllStrikes.lead_hook, AllStrikes.AllDefence.l_slip, AllStrikes.lead_hook, AllStrikes.cross }, 5, 0, 0);





            }
            public static class Combo2
            {

                public static ComboClass c_p = new ComboClass(new List<IStrike> { AllStrikes.AllDefence.pull }, 1, 0, 0);

                public static ComboClass c_p_2 = new ComboClass(new List<IStrike> { AllStrikes.AllDefence.pull, AllStrikes.cross }, 1, 0, 0);

                public static ComboClass c_p_2_3 = new ComboClass(new List<IStrike> { AllStrikes.AllDefence.pull, AllStrikes.cross, AllStrikes.lead_hook }, 1, 0, 0);

                public static ComboClass c_p_2_3_lr = new ComboClass(new List<IStrike> { AllStrikes.AllDefence.pull, AllStrikes.cross, AllStrikes.lead_hook, AllStrikes.AllDefence.l_roll }, 1, 0, 0);

                public static ComboClass c_p_2_3_lr_3 = new ComboClass(new List<IStrike> { AllStrikes.AllDefence.pull, AllStrikes.cross, AllStrikes.lead_hook, AllStrikes.AllDefence.l_roll, AllStrikes.lead_hook }, 1, 0, 0);
                public static ComboClass c_p_2_3_lr_3_2 = new ComboClass(new List<IStrike> { AllStrikes.AllDefence.pull, AllStrikes.cross, AllStrikes.lead_hook, AllStrikes.AllDefence.l_roll, AllStrikes.lead_hook, AllStrikes.cross }, 1, 0, 0);
                public static ComboClass c_p_2_3_lr_3_2_rr = new ComboClass(new List<IStrike> { AllStrikes.AllDefence.pull, AllStrikes.cross, AllStrikes.lead_hook, AllStrikes.AllDefence.l_roll, AllStrikes.lead_hook, AllStrikes.cross, AllStrikes.AllDefence.r_roll }, 1, 0, 0);
                public static ComboClass c_p_2_3_lr_3_2_rr_2 = new ComboClass(new List<IStrike> { AllStrikes.AllDefence.pull, AllStrikes.cross, AllStrikes.lead_hook, AllStrikes.AllDefence.l_roll, AllStrikes.lead_hook, AllStrikes.cross, AllStrikes.AllDefence.r_roll, AllStrikes.cross }, 1, 0, 0);
                public static ComboClass c_p_2_3_lr_3_2_rr_2_3 = new ComboClass(new List<IStrike> { AllStrikes.AllDefence.pull, AllStrikes.cross, AllStrikes.lead_hook, AllStrikes.AllDefence.l_roll, AllStrikes.lead_hook, AllStrikes.cross, AllStrikes.AllDefence.r_roll, AllStrikes.cross, AllStrikes.lead_hook }, 5, 0, 0);









            }
            public static class Combo3
            {

                public static ComboClass c_1 = new ComboClass(new List<IStrike> { AllStrikes.jab }, 1, 0, 0);

                public static ComboClass c_1_2 = new ComboClass(new List<IStrike> { AllStrikes.jab, AllStrikes.cross }, 1, 0, 0);

                public static ComboClass c_1_2_3b = new ComboClass(new List<IStrike> { AllStrikes.jab, AllStrikes.cross, AllStrikes.lead_hook_b }, 1, 0, 0);

                public static ComboClass c_1_2_3b_rc = new ComboClass(new List<IStrike> { AllStrikes.jab, AllStrikes.cross, AllStrikes.lead_hook_b, AllStrikes.AllDefence.r_catch }, 1, 0, 0);

                public static ComboClass c_1_2_3b_rc_3 = new ComboClass(new List<IStrike> { AllStrikes.jab, AllStrikes.cross, AllStrikes.lead_hook_b, AllStrikes.AllDefence.r_catch, AllStrikes.lead_hook }, 1, 0, 0);
                public static ComboClass c_1_2_3b_rc_3_6 = new ComboClass(new List<IStrike> { AllStrikes.jab, AllStrikes.cross, AllStrikes.lead_hook_b, AllStrikes.AllDefence.r_catch, AllStrikes.lead_hook, AllStrikes.rear_upper }, 1, 0, 0);
                public static ComboClass c_1_2_3b_rc_3_6_lc = new ComboClass(new List<IStrike> { AllStrikes.jab, AllStrikes.cross, AllStrikes.lead_hook_b, AllStrikes.AllDefence.r_catch, AllStrikes.lead_hook, AllStrikes.rear_upper, AllStrikes.AllDefence.l_catch }, 1, 0, 0);
                public static ComboClass c_1_2_3b_rc_3_6_lc_6 = new ComboClass(new List<IStrike> { AllStrikes.jab, AllStrikes.cross, AllStrikes.lead_hook_b, AllStrikes.AllDefence.r_catch, AllStrikes.lead_hook, AllStrikes.rear_upper, AllStrikes.AllDefence.l_catch, AllStrikes.rear_upper }, 1, 0, 0);

                public static ComboClass c_1_2_3b_rc_3_6_lc_6_3 = new ComboClass(new List<IStrike> { AllStrikes.jab, AllStrikes.cross, AllStrikes.lead_hook_b, AllStrikes.AllDefence.r_catch, AllStrikes.lead_hook, AllStrikes.rear_upper, AllStrikes.AllDefence.l_catch, AllStrikes.rear_upper, AllStrikes.lead_hook }, 5, 0, 0);













            }
            public static class Combo4
            {

                public static ComboClass c_1 = new ComboClass(new List<IStrike> { AllStrikes.jab }, 1, 0, 0);

                public static ComboClass c_1_ls = new ComboClass(new List<IStrike> { AllStrikes.jab, AllStrikes.AllDefence.l_slip }, 1, 0, 0);

                public static ComboClass c_1_ls_3b = new ComboClass(new List<IStrike> { AllStrikes.jab, AllStrikes.AllDefence.l_slip, AllStrikes.lead_hook_b }, 1, 0, 0);

                public static ComboClass c_1_ls_3b_5 = new ComboClass(new List<IStrike> { AllStrikes.jab, AllStrikes.AllDefence.l_slip, AllStrikes.lead_hook_b, AllStrikes.lead_upper }, 1, 0, 0);

                public static ComboClass c_1_ls_3b_5_2 = new ComboClass(new List<IStrike> { AllStrikes.jab, AllStrikes.AllDefence.l_slip, AllStrikes.lead_hook_b, AllStrikes.lead_upper, AllStrikes.cross, }, 1, 0, 0);
                public static ComboClass c_1_ls_3b_5_2_rs = new ComboClass(new List<IStrike> { AllStrikes.jab, AllStrikes.AllDefence.l_slip, AllStrikes.lead_hook_b, AllStrikes.lead_upper, AllStrikes.cross, AllStrikes.AllDefence.r_slip }, 1, 0, 0);
                public static ComboClass c_1_ls_3b_5_2_rs_2 = new ComboClass(new List<IStrike> { AllStrikes.jab, AllStrikes.AllDefence.l_slip, AllStrikes.lead_hook_b, AllStrikes.lead_upper, AllStrikes.cross, AllStrikes.AllDefence.r_slip, AllStrikes.cross }, 1, 0, 0);
                public static ComboClass c_1_ls_3b_5_2_rs_2_6 = new ComboClass(new List<IStrike> { AllStrikes.jab, AllStrikes.AllDefence.l_slip, AllStrikes.lead_hook_b, AllStrikes.lead_upper, AllStrikes.cross, AllStrikes.AllDefence.r_slip, AllStrikes.cross, AllStrikes.rear_upper }, 1, 0, 0);

                public static ComboClass c_1_ls_3b_5_2_rs_2_6_4 = new ComboClass(new List<IStrike> { AllStrikes.jab, AllStrikes.AllDefence.l_slip, AllStrikes.lead_hook_b, AllStrikes.lead_upper, AllStrikes.cross, AllStrikes.AllDefence.r_slip, AllStrikes.cross, AllStrikes.rear_upper, AllStrikes.rear_hook }, 5, 0, 0);












            }







        }


        public static class CombosExercise
        {
            public static ComboClass c_pushups = new ComboClass(new List<IStrike> { AllStrikes.AllExercises.pushups }, 30);
            public static ComboClass c_burpees = new ComboClass(new List<IStrike> { AllStrikes.AllExercises.burpees }, 30);
            public static ComboClass c_situps = new ComboClass(new List<IStrike> { AllStrikes.AllExercises.situps }, 30);
            public static ComboClass c_squats = new ComboClass(new List<IStrike> { AllStrikes.AllExercises.squats }, 30);
            public static ComboClass c_shadowboxing = new ComboClass(new List<IStrike> { AllStrikes.AllExercises.shadowboxing }, 60);
            public static ComboClass c_skipping_rope = new ComboClass(new List<IStrike> { AllStrikes.AllExercises.skippingrope }, 60);
            public static ComboClass c_plank = new ComboClass(new List<IStrike> { AllStrikes.AllExercises.plank }, 60);



        }

        public static class CombosDefence
        {

            public static ComboClass c_rslip = new ComboClass(new List<IStrike> { AllStrikes.AllDefence.r_slip }, 3, 0, 0);
            public static ComboClass c_lslip = new ComboClass(new List<IStrike> { AllStrikes.AllDefence.l_slip }, 3, 0, 0);
            public static ComboClass c_lcatch = new ComboClass(new List<IStrike> { AllStrikes.AllDefence.l_catch }, 3, 0, 0);
            public static ComboClass c_rcatch = new ComboClass(new List<IStrike> { AllStrikes.AllDefence.r_catch }, 3, 0, 0);

            public static ComboClass c_pull = new ComboClass(new List<IStrike> { AllStrikes.AllDefence.pull }, 3, 0, 0);
            public static ComboClass c_lroll = new ComboClass(new List<IStrike> { AllStrikes.AllDefence.l_roll }, 3, 0, 0);
            public static ComboClass c_rroll = new ComboClass(new List<IStrike> { AllStrikes.AllDefence.r_roll }, 3, 0, 0);
            public static ComboClass c_duck = new ComboClass(new List<IStrike> { AllStrikes.AllDefence.duck }, 3, 0, 0);

            public static ComboClass c_bodyblock = new ComboClass(new List<IStrike> { AllStrikes.AllDefence.bodyblock }, 3, 0, 0);
            public static ComboClass c_lbodyblock = new ComboClass(new List<IStrike> { AllStrikes.AllDefence.l_bodyblock }, 3, 0, 0);
            public static ComboClass c_rbodyblock = new ComboClass(new List<IStrike> { AllStrikes.AllDefence.r_bodyblock }, 3, 0, 0);
            public static ComboClass c_sroll = new ComboClass(new List<IStrike> { AllStrikes.AllDefence.s_roll }, 3, 0, 0);

            public static ComboClass c_lparry = new ComboClass(new List<IStrike> { AllStrikes.AllDefence.l_parry }, 3, 0, 0);
            public static ComboClass c_rparry = new ComboClass(new List<IStrike> { AllStrikes.AllDefence.r_parry }, 3, 0, 0);

        }
        public static class CombosMovement
        {

            public static ComboClass c_stepright = new ComboClass(new List<IStrike> { AllStrikes.AllMovements.step_right }, 3, 0, 0);
            public static ComboClass c_stepleft = new ComboClass(new List<IStrike> { AllStrikes.AllMovements.step_left }, 3, 0, 0);
            public static ComboClass c_stepback = new ComboClass(new List<IStrike> { AllStrikes.AllMovements.step_back }, 3, 0, 0);
            public static ComboClass c_stepforward = new ComboClass(new List<IStrike> { AllStrikes.AllMovements.step_forward }, 3, 0, 0);

            public static ComboClass c_isidestep = new ComboClass(new List<IStrike> { AllStrikes.AllMovements.i_sidestep }, 3, 0, 0);
            public static ComboClass c_osidestep = new ComboClass(new List<IStrike> { AllStrikes.AllMovements.o_sidestep }, 3, 0, 0);


        }

        public static class CombosAdvice
        {
            public static ComboClass c_basicstrikesintro = new ComboClass(new List<IStrike> { AllStrikes.AllAdvice.basic_strikes_intro }, 3, 0, 0);
            public static ComboClass c_2punchcombos = new ComboClass(new List<IStrike> { AllStrikes.AllAdvice.two_p_combos }, 3, 0, 0);

            public static ComboClass c_defenceonly = new ComboClass(new List<IStrike> { AllStrikes.AllAdvice.defence_only }, 3, 0, 0);
            public static ComboClass c_counters = new ComboClass(new List<IStrike> { AllStrikes.AllAdvice.add_counters }, 3, 0, 0);

            public static ComboClass c_moveonly = new ComboClass(new List<IStrike> { AllStrikes.AllAdvice.move_only }, 3, 0, 0);
            public static ComboClass c_combosaftermoves = new ComboClass(new List<IStrike> { AllStrikes.AllAdvice.combos_after_moves }, 3, 0, 0);

            public static ComboClass c_mixitup = new ComboClass(new List<IStrike> { AllStrikes.AllAdvice.mix_it_up }, 3, 0, 0);

            public static ComboClass c_3punchcombos = new ComboClass(new List<IStrike> { AllStrikes.AllAdvice.three_p_combos }, 3, 0, 0);
            public static ComboClass c_3punchwithdefencecombos = new ComboClass(new List<IStrike> { AllStrikes.AllAdvice.three_p_combos_defence }, 3, 0, 0);
            public static ComboClass c_3punchwithmovementcombos = new ComboClass(new List<IStrike> { AllStrikes.AllAdvice.three_p_combos_movement }, 3, 0, 0);

            public static ComboClass c_headmovementonly = new ComboClass(new List<IStrike> { AllStrikes.AllAdvice.headmovement_only }, 3, 0, 0);


            public static ComboClass c_moveyourhead = new ComboClass(new List<IStrike> { AllStrikes.AllAdvice.moveyourhead }, 3, 0, 0);
            public static ComboClass c_keepmoving = new ComboClass(new List<IStrike> { AllStrikes.AllAdvice.keepmoving }, 3, 0, 0);
            public static ComboClass c_stanceswitch = new ComboClass(new List<IStrike> { AllStrikes.AllAdvice.switchstance }, 3, 0, 0);
            public static ComboClass c_highguard = new ComboClass(new List<IStrike> { AllStrikes.AllAdvice.highguard }, 3, 0, 0);


        }

        public class Combos1p
        {
            public static ComboClass c_1b = new ComboClass(new List<IStrike> { AllStrikes.jab_b }, 3, 0, 0);
            public static ComboClass c_2b = new ComboClass(new List<IStrike> { AllStrikes.cross_b }, 3, 0, 0);
            public static ComboClass c_3b = new ComboClass(new List<IStrike> { AllStrikes.lead_hook_b }, 3, 0, 0);
            public static ComboClass c_4b = new ComboClass(new List<IStrike> { AllStrikes.rear_hook_b }, 3, 0, 0);
            public static ComboClass c_5b = new ComboClass(new List<IStrike> { AllStrikes.lead_upper_b }, 3, 0, 0);
            public static ComboClass c_6b = new ComboClass(new List<IStrike> { AllStrikes.rear_upper_b }, 3, 0, 0);




            public static ComboClass c_1 = new ComboClass(new List<IStrike> { AllStrikes.jab }, 3, 0, 0);
            public static ComboClass c_2 = new ComboClass(new List<IStrike> { AllStrikes.cross }, 3, 0, 0);
            public static ComboClass c_3 = new ComboClass(new List<IStrike> { AllStrikes.lead_hook }, 3, 0, 0);
            public static ComboClass c_4 = new ComboClass(new List<IStrike> { AllStrikes.rear_hook }, 3, 0, 0);
            public static ComboClass c_5 = new ComboClass(new List<IStrike> { AllStrikes.lead_upper }, 3, 0, 0);
            public static ComboClass c_6 = new ComboClass(new List<IStrike> { AllStrikes.rear_upper }, 3, 0, 0);



        }

        public static class CombosCounter1p
        {
            public static ComboClass c_lp_2 = new ComboClass(new List<IStrike> { AllStrikes.AllDefence.l_parry, AllStrikes.cross }, 3, 0, 0);
            public static ComboClass c_rp_3 = new ComboClass(new List<IStrike> { AllStrikes.AllDefence.r_parry, AllStrikes.lead_hook }, 3, 0, 0);
            public static ComboClass c_lbb_5 = new ComboClass(new List<IStrike> { AllStrikes.AllDefence.l_bodyblock, AllStrikes.lead_upper }, 3, 0, 0);
            public static ComboClass c_rbb_6 = new ComboClass(new List<IStrike> { AllStrikes.AllDefence.r_bodyblock, AllStrikes.rear_upper }, 3, 0, 0);
            public static ComboClass c_lc_2 = new ComboClass(new List<IStrike> { AllStrikes.AllDefence.l_catch, AllStrikes.cross }, 3, 0, 0);
            public static ComboClass c_rc_3 = new ComboClass(new List<IStrike> { AllStrikes.AllDefence.r_catch, AllStrikes.lead_hook }, 3, 0, 0);


        }
        public static class CombosHMCounter1p
        {
            public static ComboClass c_ls_3 = new ComboClass(new List<IStrike> { AllStrikes.AllDefence.l_slip, AllStrikes.lead_hook }, 3, 0, 0);
            public static ComboClass c_rs_2 = new ComboClass(new List<IStrike> { AllStrikes.AllDefence.r_slip, AllStrikes.cross }, 3, 0, 0);
            public static ComboClass c_rr_2 = new ComboClass(new List<IStrike> { AllStrikes.AllDefence.r_roll, AllStrikes.cross }, 3, 0, 0);
            public static ComboClass c_lr_3 = new ComboClass(new List<IStrike> { AllStrikes.AllDefence.l_roll, AllStrikes.lead_hook }, 3, 0, 0);
            public static ComboClass c_d_2 = new ComboClass(new List<IStrike> { AllStrikes.AllDefence.duck, AllStrikes.cross }, 3, 0, 0);
            public static ComboClass c_p_2 = new ComboClass(new List<IStrike> { AllStrikes.AllDefence.pull, AllStrikes.cross }, 3, 0, 0);


        }
        public static class CombosMoveAnd1p
        {
            public static ComboClass c_sb_2 = new ComboClass(new List<IStrike> { AllStrikes.AllMovements.step_back, AllStrikes.cross }, 3, 0, 0);
            public static ComboClass c_sf_1 = new ComboClass(new List<IStrike> { AllStrikes.AllMovements.step_forward, AllStrikes.jab }, 3, 0, 0);

            public static ComboClass c_sl_3 = new ComboClass(new List<IStrike> { AllStrikes.AllMovements.step_left, AllStrikes.lead_hook }, 3, 0, 0);
            public static ComboClass c_sr_4 = new ComboClass(new List<IStrike> { AllStrikes.AllMovements.step_right, AllStrikes.rear_hook }, 3, 0, 0);



        }
        public static class CombosMoveAndPunches
        {
            public static ComboClass c_sb_2_3 = new ComboClass(new List<IStrike> { AllStrikes.AllMovements.step_back, AllStrikes.cross, AllStrikes.lead_hook }, 3, 0, 0);
            public static ComboClass c_sf_1_2 = new ComboClass(new List<IStrike> { AllStrikes.AllMovements.step_forward, AllStrikes.jab, AllStrikes.cross }, 3, 0, 0);
            public static ComboClass c_sl_3_2 = new ComboClass(new List<IStrike> { AllStrikes.AllMovements.step_left, AllStrikes.lead_hook, AllStrikes.cross }, 3, 0, 0);
            public static ComboClass c_sr_2_3 = new ComboClass(new List<IStrike> { AllStrikes.AllMovements.step_right, AllStrikes.cross, AllStrikes.lead_hook }, 3, 0, 0);

        }

        public static class Combos2s
        {
            public static ComboClass c_os_2 = new ComboClass(new List<IStrike> { AllStrikes.AllMovements.o_sidestep, AllStrikes.cross }, 3, 0, 0);
            public static ComboClass c_is_2 = new ComboClass(new List<IStrike> { AllStrikes.AllMovements.i_sidestep, AllStrikes.cross }, 3, 0, 0);


            public static ComboClass c_1_2 = new ComboClass(new List<IStrike> { AllStrikes.jab, AllStrikes.cross }, 3, 0, 0);
            public static ComboClass c_1_2b = new ComboClass(new List<IStrike> { AllStrikes.jab, AllStrikes.cross_b }, 3, 0, 0);

            public static ComboClass c_2_3 = new ComboClass(new List<IStrike> { AllStrikes.cross, AllStrikes.lead_hook }, 3, 0, 0);
            public static ComboClass c_2_5 = new ComboClass(new List<IStrike> { AllStrikes.cross, AllStrikes.lead_upper }, 3, 0, 0);

            public static ComboClass c_1_4 = new ComboClass(new List<IStrike> { AllStrikes.jab, AllStrikes.rear_hook }, 3, 0, 0);
            public static ComboClass c_3_2 = new ComboClass(new List<IStrike> { AllStrikes.lead_hook, AllStrikes.cross }, 3, 0, 0);
            public static ComboClass c_3_6 = new ComboClass(new List<IStrike> { AllStrikes.lead_hook, AllStrikes.rear_upper }, 3, 0, 0);
            public static ComboClass c_3_4 = new ComboClass(new List<IStrike> { AllStrikes.lead_hook, AllStrikes.rear_hook }, 3, 0, 0);
            public static ComboClass c_5_2 = new ComboClass(new List<IStrike> { AllStrikes.lead_upper, AllStrikes.cross }, 3, 0, 0);
            public static ComboClass c_6_3 = new ComboClass(new List<IStrike> { AllStrikes.rear_upper, AllStrikes.lead_hook }, 3, 0, 0);



            public static ComboClass c_1_ls = new ComboClass(new List<IStrike> { AllStrikes.jab, AllStrikes.AllDefence.l_slip }, 3, 0, 0);



        }
        public static class Combos3s
        {
            public static ComboClass c_1_2_3 = new ComboClass(new List<IStrike> { AllStrikes.jab, AllStrikes.cross, AllStrikes.lead_hook }, 3, 0, 0);
            public static ComboClass c_1_2b_3 = new ComboClass(new List<IStrike> { AllStrikes.jab, AllStrikes.cross_b, AllStrikes.lead_hook }, 3, 0, 0);
            public static ComboClass c_1_2_3b = new ComboClass(new List<IStrike> { AllStrikes.jab, AllStrikes.cross, AllStrikes.lead_hook_b }, 3, 0, 0);

            public static ComboClass c_1_1_2 = new ComboClass(new List<IStrike> { AllStrikes.jab, AllStrikes.jab, AllStrikes.cross }, 3, 0, 0);
            public static ComboClass c_1_1_2b = new ComboClass(new List<IStrike> { AllStrikes.jab, AllStrikes.jab, AllStrikes.cross_b }, 3, 0, 0);
            public static ComboClass c_6_3_2 = new ComboClass(new List<IStrike> { AllStrikes.rear_hook, AllStrikes.lead_hook, AllStrikes.cross }, 3, 0, 0);

            public static ComboClass c_2_3_6 = new ComboClass(new List<IStrike> { AllStrikes.cross, AllStrikes.lead_hook, AllStrikes.rear_upper }, 3, 0, 0);
            public static ComboClass c_3_2_5 = new ComboClass(new List<IStrike> { AllStrikes.lead_hook, AllStrikes.cross, AllStrikes.lead_upper }, 3, 0, 0);
            public static ComboClass c_5_2_3 = new ComboClass(new List<IStrike> { AllStrikes.lead_upper, AllStrikes.cross, AllStrikes.lead_hook }, 3, 0, 0);

            public static ComboClass c_3_6_5 = new ComboClass(new List<IStrike> { AllStrikes.lead_hook, AllStrikes.rear_upper, AllStrikes.lead_upper }, 3, 0, 0);
            public static ComboClass c_3_6_3b = new ComboClass(new List<IStrike> { AllStrikes.lead_hook, AllStrikes.rear_upper, AllStrikes.lead_hook_b }, 3, 0, 0);



            public static ComboClass c_1_sr_rs = new ComboClass(new List<IStrike> { AllStrikes.jab, AllStrikes.AllMovements.step_right, AllStrikes.AllDefence.r_slip }, 3, 0, 0);
            public static ComboClass c_1_ls_3 = new ComboClass(new List<IStrike> { AllStrikes.jab, AllStrikes.AllDefence.l_slip, AllStrikes.lead_hook }, 3, 0, 0);



        }
        public static class Combos4s
        {
            public static ComboClass c_1_2_3_sb = new ComboClass(new List<IStrike> { AllStrikes.jab, AllStrikes.cross, AllStrikes.lead_hook, AllStrikes.AllMovements.step_back }, 3, 0, 0);
            public static ComboClass c_1_1_2_sb = new ComboClass(new List<IStrike> { AllStrikes.jab, AllStrikes.jab, AllStrikes.cross, AllStrikes.AllMovements.step_back }, 3, 0, 0);
            public static ComboClass c_2_3_2_sb = new ComboClass(new List<IStrike> { AllStrikes.cross, AllStrikes.lead_hook, AllStrikes.cross, AllStrikes.AllMovements.step_back }, 3, 0, 0);
            public static ComboClass c_sf_1_2_sb = new ComboClass(new List<IStrike> { AllStrikes.AllMovements.step_forward, AllStrikes.jab, AllStrikes.cross, AllStrikes.AllMovements.step_back }, 3, 0, 0);
            public static ComboClass c_sf_2_3_sb = new ComboClass(new List<IStrike> { AllStrikes.AllMovements.step_forward, AllStrikes.cross, AllStrikes.lead_hook, AllStrikes.AllMovements.step_back }, 3, 0, 0);
            public static ComboClass c_sf_6_3_sb = new ComboClass(new List<IStrike> { AllStrikes.AllMovements.step_forward, AllStrikes.rear_upper, AllStrikes.lead_hook, AllStrikes.AllMovements.step_back }, 3, 0, 0);


            public static ComboClass c_sr_1_2_sr = new ComboClass(new List<IStrike> { AllStrikes.AllMovements.step_forward, AllStrikes.jab, AllStrikes.cross, AllStrikes.AllMovements.step_right }, 3, 0, 0);
            public static ComboClass c_1_2_sb_2 = new ComboClass(new List<IStrike> { AllStrikes.jab, AllStrikes.cross, AllStrikes.AllMovements.step_back, AllStrikes.cross }, 3, 0, 0);
            public static ComboClass c_1_2_sr_4 = new ComboClass(new List<IStrike> { AllStrikes.jab, AllStrikes.cross, AllStrikes.AllMovements.step_right, AllStrikes.rear_hook }, 3, 0, 0);
            public static ComboClass c_1_sf_1_sb = new ComboClass(new List<IStrike> { AllStrikes.jab, AllStrikes.AllMovements.step_forward, AllStrikes.jab, AllStrikes.AllMovements.step_back }, 3, 0, 0);
            public static ComboClass c_1_2_is_os = new ComboClass(new List<IStrike> { AllStrikes.jab, AllStrikes.cross, AllStrikes.AllMovements.i_sidestep, AllStrikes.AllMovements.o_sidestep }, 3, 0, 0);

            public static ComboClass c_1_2_3_2 = new ComboClass(new List<IStrike> { AllStrikes.jab, AllStrikes.cross, AllStrikes.lead_hook, AllStrikes.cross }, 3, 0, 0);
            public static ComboClass c_1_ls_3_sr = new ComboClass(new List<IStrike> { AllStrikes.jab, AllStrikes.AllDefence.l_slip, AllStrikes.lead_hook, AllStrikes.AllMovements.step_right }, 3, 0, 0);

            public static ComboClass c_1_ls_3_2 = new ComboClass(new List<IStrike> { AllStrikes.jab, AllStrikes.cross, AllStrikes.lead_hook, AllStrikes.cross }, 3, 0, 0);



        }
        public static class Combos5s
        {
            public static ComboClass c_1_2_3_rs_2 = new ComboClass(new List<IStrike> { AllStrikes.jab, AllStrikes.cross, AllStrikes.lead_hook, AllStrikes.AllDefence.r_slip, AllStrikes.cross }, 3, 0, 0);
            public static ComboClass c_1_ls_3_sr_2 = new ComboClass(new List<IStrike> { AllStrikes.jab, AllStrikes.AllDefence.l_slip, AllStrikes.lead_hook, AllStrikes.AllMovements.step_right, AllStrikes.cross }, 3, 0, 0);



        }

        public static class Combos6s
        {
            public static ComboClass c_1_2_3_rs_2_3b = new ComboClass(new List<IStrike> { AllStrikes.jab, AllStrikes.cross, AllStrikes.lead_hook, AllStrikes.AllDefence.r_slip, AllStrikes.cross, AllStrikes.AllDefence.r_slip }, 3, 0, 0);



        }
        public static class CombosHM
        {
            public static ComboClass c_HM0 = new ComboClass(new List<IStrike> { AllStrikes.jab, AllStrikes.AllDefence.l_slip, AllStrikes.jab, AllStrikes.cross, AllStrikes.AllDefence.r_slip, AllStrikes.cross, AllStrikes.lead_hook, AllStrikes.AllDefence.l_slip, AllStrikes.lead_hook, AllStrikes.cross }, 3, 0, 0);

        }

    }



    public static class AllWorkouts
    {
        public static class TechWorkouts
        {

            public static WorkoutClass workout0 = new WorkoutClass("0",new List<ComboClass> { AllCombos.Combos3s.c_1_sr_rs, AllCombos.Combos6s.c_1_2_3_rs_2_3b, AllCombos.Combos2s.c_1_ls, AllCombos.Combos1p.c_1b, AllCombos.Combos2s.c_2_3, AllCombos.Combos2s.c_1_4, AllCombos.Combos1p.c_4, AllCombos.Combos3s.c_1_2_3 }, 3);
            public static WorkoutClass workout1 = new WorkoutClass("1",new List<ComboClass> { AllCombos.Combos1p.c_1b, AllCombos.Combos1p.c_2, AllCombos.Combos1p.c_3, AllCombos.CombosDefence.c_rslip, }, 3);
            public static WorkoutClass workout2 = new WorkoutClass("2", new List<ComboClass> { AllCombos.Combos1p.c_1, AllCombos.Combos2s.c_1_2, AllCombos.Combos3s.c_1_2_3, AllCombos.Combos4s.c_1_2_3_2, AllCombos.Combos1p.c_1, AllCombos.Combos2s.c_1_ls, AllCombos.Combos3s.c_1_ls_3, AllCombos.Combos4s.c_1_ls_3_sr, AllCombos.Combos5s.c_1_ls_3_sr_2, AllCombos.Combos1p.c_6, AllCombos.CombosDefence.c_pull, AllCombos.Combos2s.c_1_2, }, 3);

            public static class Technique1
            {
                public static WorkoutClass basic_punches = new WorkoutClass("Basic punches", new List<ComboClass> { AllCombos.CombosAdvice.c_basicstrikesintro, AllCombos.Combos1p.c_1, AllCombos.Combos1p.c_1b, AllCombos.Combos1p.c_2, AllCombos.Combos1p.c_3, AllCombos.Combos1p.c_3b, AllCombos.Combos1p.c_4, AllCombos.Combos1p.c_4b, AllCombos.Combos1p.c_5, AllCombos.Combos1p.c_5b, AllCombos.Combos1p.c_6, AllCombos.Combos1p.c_6b, AllCombos.CombosAdvice.c_2punchcombos, AllCombos.CombosAdvice.c_2punchcombos, AllCombos.Combos2s.c_1_2, AllCombos.Combos2s.c_1_2b, AllCombos.Combos2s.c_1_4, AllCombos.Combos2s.c_2_3, AllCombos.Combos2s.c_2_5, AllCombos.Combos2s.c_3_2, AllCombos.Combos2s.c_3_6, AllCombos.Combos2s.c_3_4, AllCombos.Combos2s.c_5_2, AllCombos.Combos2s.c_6_3 }, 3);
                public static WorkoutClass basic_defence = new WorkoutClass("Basic defence", new List<ComboClass> { AllCombos.CombosAdvice.c_defenceonly, AllCombos.CombosDefence.c_lparry, AllCombos.CombosDefence.c_rparry, AllCombos.CombosDefence.c_lcatch, AllCombos.CombosDefence.c_rcatch, AllCombos.CombosDefence.c_lbodyblock, AllCombos.CombosDefence.c_rbodyblock, AllCombos.CombosDefence.c_bodyblock, AllCombos.CombosAdvice.c_counters, AllCombos.CombosCounter1p.c_lp_2, AllCombos.CombosCounter1p.c_rp_3, AllCombos.CombosCounter1p.c_lc_2, AllCombos.CombosCounter1p.c_rc_3, AllCombos.CombosCounter1p.c_lbb_5, AllCombos.CombosCounter1p.c_rbb_6 }, 3);
                public static WorkoutClass basic_movement = new WorkoutClass("Basic movement", new List<ComboClass> { AllCombos.CombosAdvice.c_moveonly, AllCombos.CombosMovement.c_stepforward, AllCombos.CombosMovement.c_stepback, AllCombos.CombosMovement.c_stepright, AllCombos.CombosMovement.c_stepleft, AllCombos.CombosMovement.c_osidestep, AllCombos.CombosMovement.c_isidestep, AllCombos.CombosAdvice.c_combosaftermoves, AllCombos.CombosMoveAnd1p.c_sf_1, AllCombos.CombosMoveAnd1p.c_sb_2, AllCombos.CombosMoveAnd1p.c_sl_3, AllCombos.CombosMoveAnd1p.c_sr_4, AllCombos.CombosMoveAndPunches.c_sf_1_2, AllCombos.CombosMoveAndPunches.c_sb_2_3, AllCombos.CombosMoveAndPunches.c_sl_3_2, AllCombos.Combos2s.c_os_2, AllCombos.Combos2s.c_is_2, AllCombos.CombosMoveAndPunches.c_sr_2_3 }, 3);
                public static WorkoutClass basic_all = new WorkoutClass("Basic strikes - all", new List<ComboClass> {
    AllCombos.CombosAdvice.c_mixitup,
         AllCombos.Combos1p.c_3b,

    AllCombos.Combos1p.c_6b,
    AllCombos.Combos2s.c_2_5,
    AllCombos.Combos1p.c_2,
    AllCombos.Combos2s.c_5_2,
    AllCombos.Combos1p.c_3,
    AllCombos.Combos1p.c_1b,
    AllCombos.Combos1p.c_1,
    AllCombos.Combos2s.c_3_2,
    AllCombos.Combos1p.c_6,
    AllCombos.Combos2s.c_1_2,
    AllCombos.Combos2s.c_3_6,
    AllCombos.Combos2s.c_3_4,
    AllCombos.Combos2s.c_1_4,
    AllCombos.Combos1p.c_5b,
    AllCombos.Combos2s.c_6_3,
    AllCombos.Combos1p.c_4,
    AllCombos.Combos1p.c_5,
    AllCombos.Combos2s.c_2_3,
    AllCombos.Combos1p.c_4b,

    // Kombinace z basic defence
    AllCombos.CombosDefence.c_lparry,
    AllCombos.CombosDefence.c_rbodyblock,
    AllCombos.CombosCounter1p.c_lbb_5,
    AllCombos.CombosCounter1p.c_rbb_6,
    AllCombos.CombosCounter1p.c_rp_3,
    AllCombos.CombosDefence.c_rcatch,
    AllCombos.CombosDefence.c_lbodyblock,
    AllCombos.CombosCounter1p.c_lp_2,
    AllCombos.CombosCounter1p.c_lc_2,
    AllCombos.CombosDefence.c_lcatch,
    AllCombos.CombosDefence.c_bodyblock,
    AllCombos.CombosDefence.c_rparry,
    AllCombos.CombosCounter1p.c_rc_3,

    // Kombinace z basic movement
    AllCombos.CombosMovement.c_stepback,
    AllCombos.CombosMoveAndPunches.c_sl_3_2,
    AllCombos.CombosMoveAndPunches.c_sr_2_3,
    AllCombos.CombosMovement.c_stepright,
    AllCombos.CombosMovement.c_stepleft,
    AllCombos.CombosMoveAnd1p.c_sl_3,
    AllCombos.CombosMoveAnd1p.c_sf_1,
    AllCombos.CombosMovement.c_osidestep,
    AllCombos.Combos2s.c_os_2,
        AllCombos.CombosMovement.c_isidestep,
        AllCombos.Combos2s.c_is_2,
    AllCombos.CombosMoveAndPunches.c_sf_1_2,
    AllCombos.CombosMoveAnd1p.c_sb_2,
    AllCombos.CombosMovement.c_stepforward,
    AllCombos.CombosMoveAndPunches.c_sb_2_3,
    AllCombos.CombosMoveAnd1p.c_sr_4}, 3);



            }
            public static class Technique2
            {

                public static WorkoutClass longercombos_workout = new WorkoutClass("Longer combos", new List<ComboClass> { AllCombos.CombosAdvice.c_3punchcombos, AllCombos.Combos3s.c_1_2_3, AllCombos.Combos3s.c_1_1_2, AllCombos.Combos3s.c_1_2b_3, AllCombos.Combos3s.c_1_2_3b, AllCombos.Combos3s.c_6_3_2, AllCombos.Combos3s.c_3_6_3b, AllCombos.Combos3s.c_3_2_5, AllCombos.Combos3s.c_3_6_5 }, 3);

                public static WorkoutClass longercombosWithMoves_workout = new WorkoutClass("Longer combos with moves", new List<ComboClass> { AllCombos.CombosAdvice.c_3punchwithmovementcombos, AllCombos.Combos4s.c_1_1_2_sb, AllCombos.Combos4s.c_1_2_3_sb, AllCombos.Combos4s.c_2_3_2_sb, AllCombos.Combos4s.c_sf_2_3_sb, AllCombos.Combos4s.c_sf_6_3_sb, AllCombos.Combos4s.c_sf_1_2_sb, AllCombos.Combos4s.c_sr_1_2_sr, AllCombos.Combos4s.c_1_2_sb_2, AllCombos.Combos4s.c_1_2_sr_4, AllCombos.Combos4s.c_1_2_is_os }, 3);



                //dodelat
                public static WorkoutClass headmovement_workout = new WorkoutClass("Headmovement", new List<ComboClass> { AllCombos.CombosAdvice.c_headmovementonly,
                AllCombos.CombosDefence.c_lslip, AllCombos.CombosDefence.c_rslip, AllCombos.CombosDefence.c_lroll, AllCombos.CombosDefence.c_rroll, AllCombos.CombosDefence.c_pull, AllCombos.CombosDefence.c_duck, AllCombos.CombosAdvice.c_counters, AllCombos.CombosHMCounter1p.c_rs_2, AllCombos.CombosHMCounter1p.c_ls_3, AllCombos.CombosHMCounter1p.c_lr_3, AllCombos.CombosHMCounter1p.c_rr_2, AllCombos.CombosHMCounter1p.c_p_2, AllCombos.CombosHMCounter1p.c_d_2}, 3);
                public static WorkoutClass longercombosWithAll_workout = new WorkoutClass( "Longer combos - with all",new List<ComboClass>
                {
                



    // Kombinace z longercombos_workout
        AllCombos.Combos3s.c_1_2_3b,
        AllCombos.Combos3s.c_1_2_3,
        AllCombos.Combos3s.c_3_6_3b,
        AllCombos.Combos3s.c_1_2b_3,
        AllCombos.Combos3s.c_1_1_2,
        AllCombos.Combos3s.c_6_3_2,
        AllCombos.Combos3s.c_3_2_5,
        AllCombos.Combos3s.c_3_6_5,

        // Kombinace z longercombosWithMoves_workout
        AllCombos.Combos4s.c_1_1_2_sb,
        AllCombos.Combos4s.c_1_2_3_sb,
        AllCombos.Combos4s.c_2_3_2_sb,
        AllCombos.Combos4s.c_sf_2_3_sb,
        AllCombos.Combos4s.c_sf_6_3_sb,
        AllCombos.Combos4s.c_sf_1_2_sb,
        AllCombos.Combos4s.c_sr_1_2_sr,
        AllCombos.Combos4s.c_1_2_sb_2,
        AllCombos.Combos4s.c_1_2_sr_4,
        AllCombos.Combos4s.c_1_2_is_os,

        // Kombinace z headmovement_workout
        AllCombos.CombosDefence.c_lslip,
        AllCombos.CombosDefence.c_rslip,
        AllCombos.CombosDefence.c_lroll,
        AllCombos.CombosDefence.c_rroll,
        AllCombos.CombosDefence.c_pull,
        AllCombos.CombosDefence.c_duck,
        AllCombos.CombosHMCounter1p.c_rs_2,
        AllCombos.CombosHMCounter1p.c_ls_3,
        AllCombos.CombosHMCounter1p.c_lr_3,
        AllCombos.CombosHMCounter1p.c_rr_2,
        AllCombos.CombosHMCounter1p.c_p_2,
        AllCombos.CombosHMCounter1p.c_d_2
}, 3);
            }

            public static class ComboBuilder
            {
                public static WorkoutClass combobuild_workout = new WorkoutClass("Combo 1", new List<ComboClass> { AllCombos.CombosBuilder.Combo1.c_1, AllCombos.CombosBuilder.Combo1.c_1_ls, AllCombos.CombosBuilder.Combo1.c_1_ls_1, AllCombos.CombosBuilder.Combo1.c_1_ls_1_2, AllCombos.CombosBuilder.Combo1.c_1_ls_1_2_rs, AllCombos.CombosBuilder.Combo1.c_1_ls_1_2_rs_2, AllCombos.CombosBuilder.Combo1.c_1_ls_1_2_rs_2_3, AllCombos.CombosBuilder.Combo1.c_1_ls_1_2_rs_2_3_ls, AllCombos.CombosBuilder.Combo1.c_1_ls_1_2_rs_2_3_ls_3, AllCombos.CombosBuilder.Combo1.c_1_ls_1_2_rs_2_3_ls_3_2 }, 3);

                public static WorkoutClass combobuild_workout2 = new WorkoutClass("Combo 2", new List<ComboClass> { AllCombos.CombosBuilder.Combo2.c_p, AllCombos.CombosBuilder.Combo2.c_p_2, AllCombos.CombosBuilder.Combo2.c_p_2_3, AllCombos.CombosBuilder.Combo2.c_p_2_3_lr, AllCombos.CombosBuilder.Combo2.c_p_2_3_lr_3, AllCombos.CombosBuilder.Combo2.c_p_2_3_lr_3_2, AllCombos.CombosBuilder.Combo2.c_p_2_3_lr_3_2_rr, AllCombos.CombosBuilder.Combo2.c_p_2_3_lr_3_2_rr_2, AllCombos.CombosBuilder.Combo2.c_p_2_3_lr_3_2_rr_2_3 }, 3);
                public static WorkoutClass combobuild_workout3 = new WorkoutClass("Combo 3", new List<ComboClass> { AllCombos.CombosBuilder.Combo3.c_1, AllCombos.CombosBuilder.Combo3.c_1_2, AllCombos.CombosBuilder.Combo3.c_1_2_3b, AllCombos.CombosBuilder.Combo3.c_1_2_3b_rc, AllCombos.CombosBuilder.Combo3.c_1_2_3b_rc_3, AllCombos.CombosBuilder.Combo3.c_1_2_3b_rc_3_6, AllCombos.CombosBuilder.Combo3.c_1_2_3b_rc_3_6_lc, AllCombos.CombosBuilder.Combo3.c_1_2_3b_rc_3_6_lc_6, AllCombos.CombosBuilder.Combo3.c_1_2_3b_rc_3_6_lc_6_3 }, 3);
                public static WorkoutClass combobuild_workout4 = new WorkoutClass("Combo 4", new List<ComboClass> { AllCombos.CombosBuilder.Combo4.c_1, AllCombos.CombosBuilder.Combo4.c_1_ls, AllCombos.CombosBuilder.Combo4.c_1_ls_3b, AllCombos.CombosBuilder.Combo4.c_1_ls_3b_5, AllCombos.CombosBuilder.Combo4.c_1_ls_3b_5_2, AllCombos.CombosBuilder.Combo4.c_1_ls_3b_5_2_rs, AllCombos.CombosBuilder.Combo4.c_1_ls_3b_5_2_rs_2, AllCombos.CombosBuilder.Combo4.c_1_ls_3b_5_2_rs_2_6, AllCombos.CombosBuilder.Combo4.c_1_ls_3b_5_2_rs_2_6_4 }, 3);



            }

            public static class Styles
            {


                public static WorkoutClass switchhitting_workout = new WorkoutClass("Switch hitting",new List<ComboClass>
{
    AllCombos.Combos1p.c_1,     // Basic strikes
        AllCombos.CombosAdvice.c_stanceswitch,     // Basic strikes

    AllCombos.Combos2s.c_2_5, // Complex combo
        AllCombos.CombosAdvice.c_stanceswitch,     // Basic strikes
    AllCombos.Combos2s.c_1_ls,         // Left straight
        AllCombos.CombosAdvice.c_stanceswitch,     // Basic strikes
    AllCombos.Combos1p.c_1b,           // Body jab
        AllCombos.CombosAdvice.c_stanceswitch,     // Basic strikes
}, 3);
                public static WorkoutClass pressurefighter_workout = new WorkoutClass("Pressure fighter", new List<ComboClass>
{
    AllCombos.CombosAdvice.c_highguard,  // High guard
    AllCombos.CombosMovement.c_stepforward,  // Move forward
    AllCombos.Combos1p.c_6,               // Uppercut
    AllCombos.Combos2s.c_1_2b,             // Jab, uppercut
    //AllCombos.CombosMove.c_move_forward,  // Move forward
    AllCombos.Combos2s.c_3_2,             // Uppercuts
    AllCombos.Combos3s.c_6_3_2,           // Jab, cross, short uppercut
    AllCombos.Combos1p.c_6,               // Another uppercut
    //AllCombos.CombosMove.c_move_forward,  // Pressure with movement
    AllCombos.Combos1p.c_1b,              // Body jab (close distance)
}, 3);




                public static WorkoutClass longrangefighter_workout = new WorkoutClass("Long range fighter", new List<ComboClass>
{
                    AllCombos.CombosMovement.c_stepback,             // Total jab focus
                                        AllCombos.CombosAdvice.c_keepmoving,             // Total jab focus

    AllCombos.Combos1p.c_1,             // Total jab focus
    //AllCombos.CombosMove.c_move_back,   // Move back (footwork)
    AllCombos.Combos2s.c_1_2,           // Jab, cross
                                            AllCombos.CombosAdvice.c_keepmoving,             // Total jab focus

    //AllCombos.CombosMove.c_sidestep_left, // Sidestep left
    AllCombos.Combos3s.c_1_2_3,         // Jab, cross, hook
    //AllCombos.CombosMove.c_move_back,   // Move back
    AllCombos.Combos2s.c_1_4,           // Jab, rear uppercut
    //AllCombos.CombosMove.c_sidestep_right, // Sidestep right
    AllCombos.Combos1p.c_1b,            // Jab to body
                                            AllCombos.CombosAdvice.c_keepmoving,             // Total jab focus
                                                                AllCombos.CombosMovement.c_isidestep,             // Total jab focus

    //AllCombos.CombosMove.c_move_back,   // Move back (maintain distance)
}, 3);

                public static WorkoutClass counterpuncher_workout = new WorkoutClass("Counter Puncher", new List<ComboClass>
{
                    AllCombos.CombosAdvice.c_moveyourhead, // High guard

    AllCombos.Combos1p.c_1,               // Jab
    AllCombos.CombosDefence.c_pull,       // Pull
    AllCombos.CombosHMCounter1p.c_p_2, // Pull, cross, roll right
    AllCombos.CombosDefence.c_rslip,      // Right slip
    AllCombos.Combos2s.c_1_2,             // Jab, cross
    AllCombos.CombosHMCounter1p.c_rs_2,    // Right slip, cross
    AllCombos.CombosHMCounter1p.c_ls_3,    // Left slip, lead hook
    AllCombos.CombosHMCounter1p.c_ls_3,   // Left slip, lead body hook
    AllCombos.CombosMovement.c_stepforward,  // Step forward
    AllCombos.CombosMoveAnd1p.c_sb_2,   // Step back, cross
    AllCombos.CombosAdvice.c_moveyourhead, // High guard
    AllCombos.Combos1p.c_3,               // Lead hook
    //AllCombos.CombosMove.c_keep_moving,   // Keep moving
    //AllCombos.CombosDefence.c_orthodox_guard, // Orthodox guard
    AllCombos.Combos3s.c_1_2_3,           // Jab, cross, hook
    //AllCombos.CombosDefence.c_rslip_6_3,  // Right slip, uppercut, hook
    //AllCombos.CombosDefence.c_lparry_1,   // Left parry, jab
    //AllCombos.CombosDefence.c_rparry_1_2_rroll, // Right parry, jab, cross, roll right
    AllCombos.CombosDefence.c_lroll,      // Left roll
    //AllCombos.CombosMove.c_keep_moving,   // Keep moving
    AllCombos.CombosDefence.c_pull,       // Pull
    //AllCombos.CombosDefence.c_rcatch_3,   // Right catch, lead hook
    //AllCombos.CombosDefence.c_lcatch_2   // Left catch, cross
    //AllCombos.CombosMove.c_step_back      // Step back
}, 3);
            }
        }
        public static class FitnessWorkouts
        {
            public static FitnessWorkoutClass workout2 = new FitnessWorkoutClass("",new List<ComboClass> {AllCombos.CombosExercise.c_shadowboxing, AllCombos.CombosExercise.c_burpees, AllCombos.CombosExercise.c_squats, AllCombos.CombosExercise.c_situps }, 3, 10, 5);

            public static class Cardio
            {
                public static FitnessWorkoutClass cardio1 = new FitnessWorkoutClass("", new List<ComboClass> { AllCombos.CombosExercise.c_shadowboxing, AllCombos.CombosExercise.c_pushups, AllCombos.CombosExercise.c_shadowboxing, AllCombos.CombosExercise.c_squats, AllCombos.CombosExercise.c_shadowboxing, AllCombos.CombosExercise.c_burpees }, 3, 30, 0);
                public static FitnessWorkoutClass cardio2 = new FitnessWorkoutClass("", new List<ComboClass> { AllCombos.CombosExercise.c_skipping_rope, AllCombos.CombosExercise.c_pushups, AllCombos.CombosExercise.c_skipping_rope, AllCombos.CombosExercise.c_squats, AllCombos.CombosExercise.c_skipping_rope, AllCombos.CombosExercise.c_burpees }, 3, 60, 5);

            }
            public static class Core
            {
                public static FitnessWorkoutClass core1 = new FitnessWorkoutClass("", new List<ComboClass> { AllCombos.CombosExercise.c_pushups, AllCombos.CombosExercise.c_shadowboxing, AllCombos.CombosExercise.c_squats, AllCombos.CombosExercise.c_shadowboxing, AllCombos.CombosExercise.c_burpees }, 3, 60, 5);
                public static FitnessWorkoutClass core2 = new FitnessWorkoutClass("", new List<ComboClass> { AllCombos.CombosExercise.c_pushups, AllCombos.CombosExercise.c_shadowboxing, AllCombos.CombosExercise.c_squats, AllCombos.CombosExercise.c_shadowboxing, AllCombos.CombosExercise.c_burpees }, 3, 60, 5);

            }


        }


    }



}


