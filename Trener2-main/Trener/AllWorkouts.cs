using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trener.Resources; // Namespace, kde jsou generované Resources

namespace Trener
{


    public static class AllStrikes
{

        public static string lang = Localization.GetCurrentLanguage();

        public static PunchClass jab = new PunchClass(Resources.Languages.objectsStrings.JabButton, "1", $@"Sounds\{lang}\punches\1-sound.mp3");
public static PunchClass cross = new PunchClass(Resources.Languages.objectsStrings.CrossButton, "2", $@"Sounds\{lang}\punches\2-sound.mp3");
public static PunchClass lead_hook = new PunchClass(Resources.Languages.objectsStrings.LHookButton, "3", $@"Sounds\{lang}\punches\3-sound.mp3");
        public static PunchClass rear_hook = new PunchClass(Resources.Languages.objectsStrings.RHookButton, "4", $@"Sounds\{lang}\punches\4-sound.mp3");
        public static PunchClass lead_upper = new PunchClass(Resources.Languages.objectsStrings.LUpperButton, "5", $@"Sounds\{lang}\punches\5-sound.mp3");
public static PunchClass rear_upper = new PunchClass(Resources.Languages.objectsStrings.RUpperButton, "6", $@"Sounds\{lang}\punches\6-sound.mp3");

public static PunchClass jab_b = new PunchClass(Resources.Languages.objectsStrings.BJabButton, "1b", $@"Sounds\{lang}\punches\1b-sound.mp3");
public static PunchClass cross_b = new PunchClass(Resources.Languages.objectsStrings.BCrossButton, "2b", $@"Sounds\{lang}\punches\2b-sound.mp3");
public static PunchClass lead_hook_b = new PunchClass(Resources.Languages.objectsStrings.LBHook, "3b", $@"Sounds\{lang}\punches\3b-sound.mp3");
public static PunchClass rear_hook_b = new PunchClass(Resources.Languages.objectsStrings.RBHookButton, "4b", $@"Sounds\{lang}\punches\4b-sound.mp3");
public static PunchClass lead_upper_b = new PunchClass(Resources.Languages.objectsStrings.LBUpperButton, "5b", $@"Sounds\{lang}\punches\5b-sound.mp3");
public static PunchClass rear_upper_b = new PunchClass(Resources.Languages.objectsStrings.RBUpperButton, "6b", $@"Sounds\{lang}\punches\6b-sound.mp3");



public static class AllAdvice

{

public static AdviceClass counterpuncherintro = new AdviceClass(Resources.Languages.objectsStrings.CounterpuncherIntro, $@"Sounds\{lang}\other\counterpuncherintro-sound.mp3");

public static AdviceClass hands_high = new AdviceClass(Resources.Languages.objectsStrings.hands_high, $@"Sounds\{lang}\tips\hands high-sound.mp3");

public static AdviceClass basic_strikes_intro = new AdviceClass(Resources.Languages.objectsStrings.basic_strikes_introText, $@"Sounds\{lang}\workout_specific\intro-sound.mp3");
public static AdviceClass two_p_combos = new AdviceClass(Resources.Languages.objectsStrings.two_p_combosText, $@"Sounds\{lang}\workout_specific\2p-sound.mp3");

public static AdviceClass three_p_combos = new AdviceClass(Resources.Languages.objectsStrings.three_p_combosText, $@"Sounds\{lang}\workout_specific\3punchcombos-sound.mp3");
public static AdviceClass three_p_combos_movement = new AdviceClass(Resources.Languages.objectsStrings.three_p_combos_movementText, $@"Sounds\{lang}\workout_specific\3punchcomboswithmovement-sound.mp3");
public static AdviceClass three_p_combos_defence = new AdviceClass(Resources.Languages.objectsStrings.three_p_combos_defenceText, $@"Sounds\{lang}\workout_specific\3punchcomboswithdefence-sound.mp3");


public static AdviceClass defence_only = new AdviceClass(Resources.Languages.objectsStrings.defence_onlyText, $@"Sounds\{lang}\workout_specific\basic_defence_intro-sound.mp3");
public static AdviceClass add_counters = new AdviceClass(Resources.Languages.objectsStrings.add_countersText, $@"Sounds\{lang}\workout_specific\basic_defence_counters-sound.mp3");

public static AdviceClass move_only = new AdviceClass(Resources.Languages.objectsStrings.move_only, $@"Sounds\{lang}\workout_specific\basic_movement_intro-sound.mp3");
public static AdviceClass combos_after_moves = new AdviceClass(Resources.Languages.objectsStrings.combos_after_moves, $@"Sounds\{lang}\workout_specific\basic_movement_combos-sound.mp3");
public static AdviceClass mix_it_up = new AdviceClass(Resources.Languages.objectsStrings.mix_it_up, $@"Sounds\{lang}\workout_specific\basic_all-sound.mp3");


public static AdviceClass headmovement_only = new AdviceClass(Resources.Languages.objectsStrings.headmovement_only, $@"Sounds\{lang}\workout_specific\headmovementonly-sound.mp3");



public static AdviceClass moveyourhead = new AdviceClass(Resources.Languages.objectsStrings.moveyourhead, $@"Sounds\{lang}\tips\moveyourhead-sound.mp3");
public static AdviceClass switchstance = new AdviceClass(Resources.Languages.objectsStrings.switchstance, $@"Sounds\{lang}\tips\switchstance-sound.mp3");
public static AdviceClass highguard = new AdviceClass(Resources.Languages.objectsStrings.hands_high, $@"Sounds\{lang}\tips\highguard-sound.mp3");
public static AdviceClass keepmoving = new AdviceClass(Resources.Languages.objectsStrings.keepmoving, $@"Sounds\{lang}\tips\keepmoving-sound.mp3");
public static AdviceClass pressurefighterintro = new AdviceClass(Resources.Languages.objectsStrings.pressureFighterIntro, $@"Sounds\{lang}\other\pressurefighterintro-sound.mp3");
public static AdviceClass keepmovingforward = new AdviceClass(Resources.Languages.objectsStrings.keepmovingforward, $@"Sounds\{lang}\other\keepmovingforward-sound.mp3");
public static AdviceClass longrangefighterintro = new AdviceClass(Resources.Languages.objectsStrings.longrangefighterintro, $@"Sounds\{lang}\other\longrangefighter-sound.mp3");



        }
        public static class AllDefence
{
/* HEADMOVEMENT*/
public static DefenceClass r_slip = new DefenceClass(Resources.Languages.objectsStrings.RSlipButton, "RSlip", $@"Sounds\{lang}\defence\r_slip-sound.mp3");
public static DefenceClass l_slip = new DefenceClass(Resources.Languages.objectsStrings.LSlipButton, "LSlip", $@"Sounds\{lang}\defence\l_slip-sound.mp3");
public static DefenceClass pull = new DefenceClass("Pull", "Pull", $@"Sounds\{lang}\defence\pull-sound.mp3");
public static DefenceClass l_roll = new DefenceClass(Resources.Languages.objectsStrings.LRButton, "LRoll", $@"Sounds\{lang}\defence\l_roll-sound.mp3");
public static DefenceClass r_roll = new DefenceClass(Resources.Languages.objectsStrings.RRButton,"RRoll", $@"Sounds\{lang}\defence\r_roll-sound.mp3");
public static DefenceClass duck = new DefenceClass(Resources.Languages.objectsStrings.DuckButton, "Duck", $@"Sounds\{lang}\defence\duck-sound.mp3");



/* BLOK */
public static DefenceClass l_catch = new DefenceClass(Resources.Languages.objectsStrings.LCButton, "LCatch", $@"Sounds\{lang}\defence\l_catch-sound.mp3");
public static DefenceClass r_catch = new DefenceClass(Resources.Languages.objectsStrings.RCButton, "RCatch", $@"Sounds\{lang}\defence\r_catch-sound.mp3");
public static DefenceClass l_parry = new DefenceClass(Resources.Languages.objectsStrings.LPButton, "LParry", $@"Sounds\{lang}\defence\l_parry-sound.mp3");
public static DefenceClass r_parry = new DefenceClass(Resources.Languages.objectsStrings.RPButton, "RParry", $@"Sounds\{lang}\defence\r_parry-sound.mp3");

/* BODY*/
public static DefenceClass bodyblock = new DefenceClass("Bodyblock", "BBlock", $@"Sounds\{lang}\defence\bodyblock-sound.mp3");
public static DefenceClass r_bodyblock = new DefenceClass(Resources.Languages.objectsStrings.RBBButton, "RBBlock", $@"Sounds\{lang}\defence\r_bodyblock-sound.mp3");
public static DefenceClass l_bodyblock = new DefenceClass(Resources.Languages.objectsStrings.LBBButton,"LBBlock", $@"Sounds\{lang}\defence\l_bodyblock-sound.mp3");


/*shoulder roll*/
public static DefenceClass s_roll = new DefenceClass("Shoulder roll", "SRoll", $@"Sounds\{lang}\defence\s_roll-sound.mp3");


}
public static class AllMovements
{
/* steps */
public static MoveClass step_right = new MoveClass(Resources.Languages.objectsStrings.StRButton, "StepR", $@"Sounds\{lang}\movements\step_right-sound.mp3");
public static MoveClass step_left = new MoveClass(Resources.Languages.objectsStrings.StLButton, "StepL", $@"Sounds\{lang}\movements\step_left-sound.mp3");
public static MoveClass step_back = new MoveClass(Resources.Languages.objectsStrings.StBButton, "StepB", $@"Sounds\{lang}\movements\step_back-sound.mp3");
public static MoveClass step_forward = new MoveClass(Resources.Languages.objectsStrings.StFButton, "StepF", $@"Sounds\{lang}\movements\step_forward-sound.mp3");

/*pivots*/
public static MoveClass i_sidestep = new MoveClass(Resources.Languages.objectsStrings.ISButton, "ISStep", $@"Sounds\{lang}\movements\i_sidestep-sound.mp3");
public static MoveClass o_sidestep = new MoveClass(Resources.Languages.objectsStrings.OSButton, "OSStep", $@"Sounds\{lang}\movements\o_sidestep-sound.mp3");



}
public static class AllExercises
{
public static ExerciseClass pushups = new ExerciseClass("Pushups", Resources.Languages.objectsStrings.pushups, $@"Sounds\{lang}\exercises\pushups-sound.mp3");
public static ExerciseClass burpees = new ExerciseClass("Burpees", Resources.Languages.objectsStrings.burpees, $@"Sounds\{lang}\exercises\burpees-sound.mp3");
public static ExerciseClass squats = new ExerciseClass("Squats", Resources.Languages.objectsStrings.squats, $@"Sounds\{lang}\exercises\squats-sound.mp3");
public static ExerciseClass situps = new ExerciseClass("Situps", Resources.Languages.objectsStrings.situps, $@"Sounds\{lang}\exercises\situps-sound.mp3");


public static ExerciseClass shadowboxing = new ExerciseClass("Shadowboxing", Resources.Languages.objectsStrings.shadowboxing, $@"Sounds\{lang}\exercises\shadowboxing-sound.mp3");
public static ExerciseClass skippingrope = new ExerciseClass("Skipping rope", Resources.Languages.objectsStrings.skippingrope, $@"Sounds\{lang}\exercises\skippingrope-sound.mp3");
public static ExerciseClass plank = new ExerciseClass("Plank", Resources.Languages.objectsStrings.plank, $@"Sounds\{lang}\exercises\plank-sound.mp3");


}

public static class Guides
{
public static ExerciseClass closefighting = new ExerciseClass("Closefighting", Resources.Languages.objectsStrings.closefighting, $@"Sounds\{lang}\guides\closefighting-sound.mp3");
public static ExerciseClass countersonly = new ExerciseClass("Counters", Resources.Languages.objectsStrings.countersonly, $@"Sounds\{lang}\guides\countersonly-sound.mp3");
public static ExerciseClass finishwithbodyshot = new ExerciseClass("finishwithbodyshot", Resources.Languages.objectsStrings.finishwithBodyshot, $@"Sounds\{lang}\guides\finishwithbodyshot-sound.mp3");
public static ExerciseClass headmovmentandcounter = new ExerciseClass("headmovement and counters", Resources.Languages.objectsStrings.headmovementandcounter, $@"Sounds\{lang}\guides\headmovementandcounter-sound.mp3");


public static ExerciseClass moveandjab = new ExerciseClass("moveandjab", Resources.Languages.objectsStrings.moveandjab, $@"Sounds\{lang}\guides\moveandjab-sound.mp3");
public static ExerciseClass onlyhooksandupper = new ExerciseClass("onlyhooksandupper", Resources.Languages.objectsStrings.onlyhooksandupper, $@"Sounds\{lang}\guides\onlyhooksandupper-sound.mp3");
public static ExerciseClass onlystraightpunches = new ExerciseClass("onlystraightpunches", Resources.Languages.objectsStrings.onlystraightpunches, $@"Sounds\{lang}\guides\onlystraightpunches-sound.mp3");
public static ExerciseClass startwithjab = new ExerciseClass("startwithjab", Resources.Languages.objectsStrings.startwithjab, $@"Sounds\{lang}\guides\startwithjab-sound.mp3");
public static ExerciseClass twopunchcombosonly = new ExerciseClass("twopunchcombosonly",Resources.Languages.objectsStrings.twopunchcombosonly, $@"Sounds\{lang}\guides\twopunchcombosonly-sound.mp3");
public static ExerciseClass useonlyleadhand = new ExerciseClass("useonlyleadhand", Resources.Languages.objectsStrings.useonlyleadhand, $@"Sounds\{lang}\guides\useonlyleadhand-sound.mp3");


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
            public static ComboClass c_pressurefigterintro = new ComboClass(new List<IStrike> { AllStrikes.AllAdvice.pressurefighterintro }, 3, 0, 0);

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
 public static ComboClass c_keepmovingforward = new ComboClass(new List<IStrike> { AllStrikes.AllAdvice.keepmovingforward }, 3, 0, 0);
public static ComboClass c_longrangefighterintro = new ComboClass(new List<IStrike> { AllStrikes.AllAdvice.longrangefighterintro }, 3, 0, 0);
public static ComboClass c_counterpuncherintro = new ComboClass(new List<IStrike> { AllStrikes.AllAdvice.counterpuncherintro }, 3, 0, 0);


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

public static ComboClass c_3_3b = new ComboClass(new List<IStrike> { AllStrikes.lead_hook, AllStrikes.lead_hook_b }, 3, 0, 0);
public static ComboClass c_6_3b = new ComboClass(new List<IStrike> { AllStrikes.rear_upper, AllStrikes.lead_hook_b }, 3, 0, 0);
public static ComboClass c_6_4b = new ComboClass(new List<IStrike> { AllStrikes.lead_hook, AllStrikes.lead_hook_b }, 3, 0, 0);

public static ComboClass c_1_3 = new ComboClass(new List<IStrike> { AllStrikes.jab, AllStrikes.lead_hook }, 3, 0, 0);
public static ComboClass c_1_3b = new ComboClass(new List<IStrike> { AllStrikes.jab, AllStrikes.lead_hook_b }, 3, 0, 0);


}
public static class PressurefighterCombos
        {
            public static ComboClass c_3_4 = new ComboClass(new List<IStrike> { AllStrikes.lead_hook, AllStrikes.rear_hook }, 3, 0, 0);
            public static ComboClass c_3_4_3b = new ComboClass(new List<IStrike> { AllStrikes.lead_hook, AllStrikes.rear_hook,AllStrikes.lead_hook_b }, 3, 0, 0);
            public static ComboClass c_3_4_3b_6 = new ComboClass(new List<IStrike> { AllStrikes.lead_hook, AllStrikes.rear_hook, AllStrikes.lead_hook_b,AllStrikes.rear_upper }, 3, 0, 0);


            public static ComboClass c_4_3 = new ComboClass(new List<IStrike> { AllStrikes.rear_hook, AllStrikes.lead_hook }, 3, 0, 0);
            public static ComboClass c_4_3_6 = new ComboClass(new List<IStrike> { AllStrikes.rear_hook, AllStrikes.lead_hook, AllStrikes.rear_upper }, 3, 0, 0);
            public static ComboClass c_4_3_6_3b = new ComboClass(new List<IStrike> { AllStrikes.rear_hook, AllStrikes.lead_hook, AllStrikes.rear_upper, AllStrikes.lead_hook_b }, 3, 0, 0);

            public static ComboClass c_6_5 = new ComboClass(new List<IStrike> { AllStrikes.rear_upper, AllStrikes.lead_upper }, 3, 0, 0);
            public static ComboClass c_5_6 = new ComboClass(new List<IStrike> { AllStrikes.lead_upper, AllStrikes.rear_upper }, 3, 0, 0);
            public static ComboClass c_5_6_3b = new ComboClass(new List<IStrike> { AllStrikes.lead_upper, AllStrikes.rear_upper, AllStrikes.lead_hook_b }, 3, 0, 0);

        }
        public static class LongRangeFighter
        {
            public static ComboClass c_1_2_is = new ComboClass(new List<IStrike> { AllStrikes.jab, AllStrikes.cross, AllStrikes.AllMovements.i_sidestep}, 3, 0, 0);
            public static ComboClass c_1_2_3_os = new ComboClass(new List<IStrike> { AllStrikes.jab, AllStrikes.cross,AllStrikes.lead_hook, AllStrikes.AllMovements.o_sidestep }, 3, 0, 0);
            public static ComboClass c_is_os_2_3 = new ComboClass(new List<IStrike> { AllStrikes.AllMovements.i_sidestep, AllStrikes.AllMovements.o_sidestep, AllStrikes.cross, AllStrikes.lead_hook }, 3, 0, 0);


            public static ComboClass c_sb_os = new ComboClass(new List<IStrike> { AllStrikes.AllMovements.step_back, AllStrikes.AllMovements.o_sidestep }, 3, 0, 0);
            public static ComboClass c_1_2_os = new ComboClass(new List<IStrike> { AllStrikes.jab, AllStrikes.cross, AllStrikes.AllMovements.o_sidestep }, 3, 0, 0);


        }
        public static class Combos3s
{
public static ComboClass c_1_2_3 = new ComboClass(new List<IStrike> { AllStrikes.jab, AllStrikes.cross, AllStrikes.lead_hook }, 3, 0, 0);
public static ComboClass c_1_2b_3 = new ComboClass(new List<IStrike> { AllStrikes.jab, AllStrikes.cross_b, AllStrikes.lead_hook }, 3, 0, 0);
public static ComboClass c_1_2_3b = new ComboClass(new List<IStrike> { AllStrikes.jab, AllStrikes.cross, AllStrikes.lead_hook_b }, 3, 0, 0);

public static ComboClass c_1_1_2 = new ComboClass(new List<IStrike> { AllStrikes.jab, AllStrikes.jab, AllStrikes.cross }, 3, 0, 0);
public static ComboClass c_1_1_2b = new ComboClass(new List<IStrike> { AllStrikes.jab, AllStrikes.jab, AllStrikes.cross_b }, 3, 0, 0);
public static ComboClass c_6_3_2 = new ComboClass(new List<IStrike> { AllStrikes.rear_upper, AllStrikes.lead_hook, AllStrikes.cross }, 3, 0, 0);

public static ComboClass c_2_3_6 = new ComboClass(new List<IStrike> { AllStrikes.cross, AllStrikes.lead_hook, AllStrikes.rear_upper }, 3, 0, 0);
public static ComboClass c_3_2_5 = new ComboClass(new List<IStrike> { AllStrikes.lead_hook, AllStrikes.cross, AllStrikes.lead_upper }, 3, 0, 0);
public static ComboClass c_5_2_3 = new ComboClass(new List<IStrike> { AllStrikes.lead_upper, AllStrikes.cross, AllStrikes.lead_hook }, 3, 0, 0);

public static ComboClass c_3_6_5 = new ComboClass(new List<IStrike> { AllStrikes.lead_hook, AllStrikes.rear_upper, AllStrikes.lead_upper }, 3, 0, 0);
public static ComboClass c_3_6_3b = new ComboClass(new List<IStrike> { AllStrikes.lead_hook, AllStrikes.rear_upper, AllStrikes.lead_hook_b }, 3, 0, 0);



public static ComboClass c_1_sr_rs = new ComboClass(new List<IStrike> { AllStrikes.jab, AllStrikes.AllMovements.step_right, AllStrikes.AllDefence.r_slip }, 3, 0, 0);
public static ComboClass c_1_ls_3 = new ComboClass(new List<IStrike> { AllStrikes.jab, AllStrikes.AllDefence.l_slip, AllStrikes.lead_hook }, 3, 0, 0);

public static ComboClass c_1_3b_2 = new ComboClass(new List<IStrike> { AllStrikes.jab, AllStrikes.lead_hook_b, AllStrikes.cross }, 3, 0, 0);
public static ComboClass c_1_3b_4b = new ComboClass(new List<IStrike> { AllStrikes.jab, AllStrikes.lead_hook_b, AllStrikes.cross }, 3, 0, 0);
public static ComboClass c_1b_1_2 = new ComboClass(new List<IStrike> { AllStrikes.jab_b, AllStrikes.jab, AllStrikes.cross }, 3, 0, 0);
public static ComboClass c_1b_1_2b = new ComboClass(new List<IStrike> { AllStrikes.jab_b, AllStrikes.jab, AllStrikes.cross_b }, 3, 0, 0);
public static ComboClass c_6_4b_2 = new ComboClass(new List<IStrike> { AllStrikes.rear_upper, AllStrikes.rear_hook_b, AllStrikes.cross }, 3, 0, 0);

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

            public static ComboClass c_1_2_1_2 = new ComboClass(new List<IStrike> { AllStrikes.jab, AllStrikes.cross, AllStrikes.jab, AllStrikes.cross }, 3, 0, 0);


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
public static class CombosGuides
{
public static ComboClass closefighting = new ComboClass(new List<IStrike> { AllStrikes.Guides.closefighting }, 30);
public static ComboClass countersonly = new ComboClass(new List<IStrike> { AllStrikes.Guides.countersonly }, 30);
public static ComboClass finishwithbodyshot = new ComboClass(new List<IStrike> { AllStrikes.Guides.finishwithbodyshot }, 30);
public static ComboClass headmovmentandcounter = new ComboClass(new List<IStrike> { AllStrikes.Guides.headmovmentandcounter }, 30);
public static ComboClass movenadjab = new ComboClass(new List<IStrike> { AllStrikes.Guides.moveandjab }, 30);
public static ComboClass onlyhooksandupper = new ComboClass(new List<IStrike> { AllStrikes.Guides.onlyhooksandupper }, 30);
public static ComboClass onlystraightpunches = new ComboClass(new List<IStrike> { AllStrikes.Guides.onlystraightpunches }, 30);
public static ComboClass startwithjab = new ComboClass(new List<IStrike> { AllStrikes.Guides.startwithjab }, 30);
public static ComboClass twopunchcombos = new ComboClass(new List<IStrike> { AllStrikes.Guides.twopunchcombosonly }, 30);
public static ComboClass useonlyleadhand = new ComboClass(new List<IStrike> { AllStrikes.Guides.useonlyleadhand }, 30);

}

        public static class CombosCounterPuncher
        {
            public static ComboClass c_rs_6_3 = new ComboClass(new List<IStrike> { AllStrikes.AllDefence.r_slip, AllStrikes.rear_upper, AllStrikes.lead_hook }, 3, 0, 0);
            public static ComboClass c_ls_5_2 = new ComboClass(new List<IStrike> { AllStrikes.AllDefence.l_slip, AllStrikes.lead_upper, AllStrikes.cross }, 3, 0, 0);
            public static ComboClass c_lr_3_2 = new ComboClass(new List<IStrike> { AllStrikes.AllDefence.l_roll, AllStrikes.lead_hook, AllStrikes.cross }, 3, 0, 0);
            public static ComboClass c_ls_3_2 = new ComboClass(new List<IStrike> { AllStrikes.AllDefence.l_slip, AllStrikes.lead_hook, AllStrikes.cross }, 3, 0, 0);
            public static ComboClass c_rr_2_3 = new ComboClass(new List<IStrike> { AllStrikes.AllDefence.r_roll, AllStrikes.cross, AllStrikes.lead_hook }, 3, 0, 0);
            public static ComboClass c_p_2_sb = new ComboClass(new List<IStrike> { AllStrikes.AllDefence.pull, AllStrikes.cross, AllStrikes.AllMovements.step_back }, 3, 0, 0);
            public static ComboClass c_d_2_sb = new ComboClass(new List<IStrike> { AllStrikes.AllDefence.duck, AllStrikes.cross, AllStrikes.AllMovements.step_back }, 3, 0, 0);


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
    public static WorkoutClass basic_punches = new WorkoutClass(Resources.Languages.objectsStrings.basic_strikes_introText, new List<ComboClass> { AllCombos.CombosAdvice.c_basicstrikesintro, AllCombos.Combos1p.c_1, AllCombos.Combos1p.c_1b, AllCombos.Combos1p.c_2, AllCombos.Combos1p.c_3, AllCombos.Combos1p.c_3b, AllCombos.Combos1p.c_4, AllCombos.Combos1p.c_4b, AllCombos.Combos1p.c_5, AllCombos.Combos1p.c_5b, AllCombos.Combos1p.c_6, AllCombos.Combos1p.c_6b, AllCombos.CombosAdvice.c_2punchcombos, AllCombos.Combos2s.c_1_2, AllCombos.Combos2s.c_1_2b, AllCombos.Combos2s.c_1_4, AllCombos.Combos2s.c_2_3, AllCombos.Combos2s.c_2_5, AllCombos.Combos2s.c_3_2, AllCombos.Combos2s.c_3_6, AllCombos.Combos2s.c_3_4, AllCombos.Combos2s.c_5_2, AllCombos.Combos2s.c_6_3 }, 3);
    public static WorkoutClass basic_defence = new WorkoutClass(Resources.Languages.objectsStrings.BasicDefenceButton, new List<ComboClass> { AllCombos.CombosAdvice.c_defenceonly, AllCombos.CombosDefence.c_lparry, AllCombos.CombosDefence.c_rparry, AllCombos.CombosDefence.c_lcatch, AllCombos.CombosDefence.c_rcatch, AllCombos.CombosDefence.c_lbodyblock, AllCombos.CombosDefence.c_rbodyblock, AllCombos.CombosDefence.c_bodyblock, AllCombos.CombosAdvice.c_counters, AllCombos.CombosCounter1p.c_lp_2, AllCombos.CombosCounter1p.c_rp_3, AllCombos.CombosCounter1p.c_lc_2, AllCombos.CombosCounter1p.c_rc_3, AllCombos.CombosCounter1p.c_lbb_5, AllCombos.CombosCounter1p.c_rbb_6 }, 3);
    public static WorkoutClass basic_movement = new WorkoutClass(Resources.Languages.objectsStrings.BasicMovementButton, new List<ComboClass> { AllCombos.CombosAdvice.c_moveonly, AllCombos.CombosMovement.c_stepforward, AllCombos.CombosMovement.c_stepback, AllCombos.CombosMovement.c_stepright, AllCombos.CombosMovement.c_stepleft, AllCombos.CombosMovement.c_osidestep, AllCombos.CombosMovement.c_isidestep, AllCombos.CombosAdvice.c_combosaftermoves, AllCombos.CombosMoveAnd1p.c_sf_1, AllCombos.CombosMoveAnd1p.c_sb_2, AllCombos.CombosMoveAnd1p.c_sl_3, AllCombos.CombosMoveAnd1p.c_sr_4, AllCombos.CombosMoveAndPunches.c_sf_1_2, AllCombos.CombosMoveAndPunches.c_sb_2_3, AllCombos.CombosMoveAndPunches.c_sl_3_2, AllCombos.Combos2s.c_os_2, AllCombos.Combos2s.c_is_2, AllCombos.CombosMoveAndPunches.c_sr_2_3 }, 3);
    public static WorkoutClass basic_all = new WorkoutClass(Resources.Languages.objectsStrings.Tech1Button + " "+ Resources.Languages.objectsStrings.AllButton, new List<ComboClass> {
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

    public static WorkoutClass longercombos_workout = new WorkoutClass(Resources.Languages.objectsStrings.LCombosButton, new List<ComboClass> { AllCombos.CombosAdvice.c_3punchcombos, AllCombos.Combos3s.c_1_2_3, AllCombos.Combos3s.c_1_1_2, AllCombos.Combos3s.c_1_2b_3, AllCombos.Combos3s.c_1_2_3b, AllCombos.Combos3s.c_6_3_2, AllCombos.Combos3s.c_3_6_3b, AllCombos.Combos3s.c_3_2_5, AllCombos.Combos3s.c_3_6_5 }, 3);
                
    public static WorkoutClass longercombosWithMoves_workout = new WorkoutClass(Resources.Languages.objectsStrings.three_p_combos_movementText, new List<ComboClass> { AllCombos.CombosAdvice.c_3punchwithmovementcombos, AllCombos.Combos4s.c_1_1_2_sb, AllCombos.Combos4s.c_1_2_3_sb, AllCombos.Combos4s.c_2_3_2_sb, AllCombos.Combos4s.c_sf_2_3_sb, AllCombos.Combos4s.c_sf_6_3_sb, AllCombos.Combos4s.c_sf_1_2_sb, AllCombos.Combos4s.c_sr_1_2_sr, AllCombos.Combos4s.c_1_2_sb_2, AllCombos.Combos4s.c_1_2_sr_4, AllCombos.Combos4s.c_1_2_is_os }, 3);



    //dodelat
    public static WorkoutClass headmovement_workout = new WorkoutClass("Headmovement", new List<ComboClass> { AllCombos.CombosAdvice.c_headmovementonly,
    AllCombos.CombosDefence.c_lslip, AllCombos.CombosDefence.c_rslip, AllCombos.CombosDefence.c_lroll, AllCombos.CombosDefence.c_rroll, AllCombos.CombosDefence.c_pull, AllCombos.CombosDefence.c_duck, AllCombos.CombosAdvice.c_counters, AllCombos.CombosHMCounter1p.c_rs_2, AllCombos.CombosHMCounter1p.c_ls_3, AllCombos.CombosHMCounter1p.c_lr_3, AllCombos.CombosHMCounter1p.c_rr_2, AllCombos.CombosHMCounter1p.c_p_2, AllCombos.CombosHMCounter1p.c_d_2}, 3);
    public static WorkoutClass longercombosWithAll_workout = new WorkoutClass(Resources.Languages.objectsStrings.Tech2Button +" " +Resources.Languages.objectsStrings.AllButton, new List<ComboClass>
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


    public static WorkoutClass switchhitting_workout = new WorkoutClass("Switch hitting", new List<ComboClass>
{
AllCombos.Combos1p.c_1,     // Basic strikes
AllCombos.Combos1p.c_1b,

AllCombos.Combos2s.c_2_5, // Complex combo
AllCombos.CombosAdvice.c_stanceswitch,     // Basic strikes
AllCombos.Combos2s.c_1_ls,         // Left straight
AllCombos.Combos3s.c_1_ls_3,
AllCombos.Combos1p.c_1b,           // Body jab
AllCombos.Combos2s.c_1_2b,
AllCombos.CombosAdvice.c_stanceswitch,     // Basic strikes

AllCombos.CombosMovement.c_stepright,
AllCombos.CombosMoveAnd1p.c_sr_4,
    AllCombos.CombosAdvice.c_stanceswitch,     // Basic strikes
AllCombos.Combos1p.c_2b,
AllCombos.Combos2s.c_1_2,
AllCombos.CombosDefence.c_lslip,
    AllCombos.CombosDefence.c_rslip,
    AllCombos.CombosAdvice.c_stanceswitch,
            AllCombos.Combos1p.c_2b,
AllCombos.Combos2s.c_1_2,
AllCombos.CombosDefence.c_lslip,
    AllCombos.CombosDefence.c_rslip,
                    AllCombos.CombosAdvice.c_stanceswitch,     // Basic strikes
                    AllCombos.CombosMovement.c_stepforward,
                    AllCombos.Combos1p.c_6,
                    AllCombos.Combos2s.c_6_3,
        AllCombos.CombosAdvice.c_stanceswitch,     // Basic strikes
        AllCombos.Combos3s.c_1_2_3b,
                            AllCombos.CombosAdvice.c_stanceswitch,     // Basic strikes
        AllCombos.CombosMoveAnd1p.c_sf_1,
        AllCombos.Combos4s.c_1_sf_1_sb,

               
                               


}, 3);
                public static WorkoutClass pressurefighter_workout = new WorkoutClass("Pressure fighter", new List<ComboClass>
{

AllCombos.CombosAdvice.c_pressurefigterintro,  // High guard

AllCombos.Combos1p.c_1,
AllCombos.Combos2s.c_1_3,
AllCombos.Combos2s.c_1_3b,
AllCombos.Combos3s.c_1_3b_2,
AllCombos.Combos2s.c_1_2b,
AllCombos.Combos2s.c_6_3b,
AllCombos.Combos2s.c_6_4b,
AllCombos.Combos3s.c_6_4b_2,

AllCombos.CombosAdvice.c_keepmovingforward,  // High guard

AllCombos.Combos3s.c_1b_1_2,
AllCombos.Combos3s.c_1b_1_2b,
AllCombos.Combos1p.c_1b,
AllCombos.Combos3s.c_1_3b_4b,
AllCombos.CombosHMCounter1p.c_lr_3,
AllCombos.CombosHMCounter1p.c_rr_2,

AllCombos.CombosAdvice.c_moveyourhead,
AllCombos.PressurefighterCombos.c_3_4,
AllCombos.PressurefighterCombos.c_3_4_3b,
AllCombos.PressurefighterCombos.c_3_4_3b_6,

AllCombos.PressurefighterCombos.c_4_3,
AllCombos.PressurefighterCombos.c_4_3_6,
AllCombos.PressurefighterCombos.c_4_3_6_3b,




}, 3);




    public static WorkoutClass longrangefighter_workout = new WorkoutClass("Long range fighter", new List<ComboClass>
{
        AllCombos.CombosAdvice.c_longrangefighterintro,
        AllCombos.CombosMovement.c_stepback,             // Total jab focus
                            AllCombos.CombosAdvice.c_keepmoving,             // Total jab focus

AllCombos.Combos1p.c_1,             // Total jab focus
//AllCombos.CombosMove.c_move_back,   // Move back (footwork)
AllCombos.Combos2s.c_1_2,           // Jab, cross
                                AllCombos.CombosAdvice.c_keepmoving,             // Total jab focus
                                AllCombos.LongRangeFighter.c_1_2_os,

AllCombos.LongRangeFighter.c_1_2_is,
AllCombos.LongRangeFighter.c_1_2_3_os,

AllCombos.Combos2s.c_1_2,           // Jab, cross

//AllCombos.CombosMove.c_sidestep_left, // Sidestep left
AllCombos.Combos3s.c_1_2_3,         // Jab, cross, hook
//AllCombos.CombosMove.c_move_back,   // Move back
//AllCombos.CombosMove.c_sidestep_right, // Sidestep right
AllCombos.Combos1p.c_1b,
                                                    AllCombos.CombosMovement.c_isidestep,             // Total jab focus
// Jab to body
AllCombos.Combos3s.c_1_1_2,
AllCombos.Combos3s.c_1_1_2b,
AllCombos.LongRangeFighter.c_1_2_is,
AllCombos.Combos4s.c_1_2_1_2,
AllCombos.CombosMoveAnd1p.c_sb_2,
AllCombos.CombosMoveAndPunches.c_sb_2_3,
AllCombos.CombosMoveAnd1p.c_sl_3,
AllCombos.CombosMoveAnd1p.c_sr_4,

                                AllCombos.CombosAdvice.c_keepmoving,             // Total jab focus
                                                    AllCombos.CombosMovement.c_osidestep,
                                                    AllCombos.LongRangeFighter.c_1_2_is,
// Total jab focus
                                                    AllCombos.CombosAdvice.c_keepmoving,             // Total jab focus

//AllCombos.CombosMove.c_move_back,   // Move back (maintain distance)
}, 3);

    public static WorkoutClass counterpuncher_workout = new WorkoutClass("Counter Puncher", new List<ComboClass>
{
        AllCombos.CombosAdvice.c_counterpuncherintro,

AllCombos.Combos1p.c_1,               // Jab
AllCombos.CombosDefence.c_pull,       // Pull
AllCombos.CombosHMCounter1p.c_p_2, // Pull, cross, roll right
AllCombos.CombosCounterPuncher.c_p_2_sb,

AllCombos.CombosDefence.c_rslip,      // Right slip
AllCombos.Combos2s.c_1_2,             // Jab, cross
AllCombos.CombosAdvice.c_moveyourhead, // High guard

AllCombos.CombosHMCounter1p.c_rs_2,    // Right slip, cross
AllCombos.CombosCounterPuncher.c_rs_6_3,

AllCombos.CombosHMCounter1p.c_ls_3,    // Left slip, lead hook
AllCombos.CombosCounterPuncher.c_lr_3_2,

AllCombos.CombosMoveAnd1p.c_sb_2,   // Step back, cross
AllCombos.CombosAdvice.c_moveyourhead, // High guard
//AllCombos.CombosMove.c_keep_moving,   // Keep moving
//AllCombos.CombosDefence.c_orthodox_guard, // Orthodo
//x guard
AllCombos.CombosDefence.c_duck,

AllCombos.CombosCounterPuncher.c_d_2_sb,
AllCombos.Combos3s.c_1_2_3,           // Jab, cross, hook
//AllCombos.CombosDefence.c_rslip_6_3,  // Right slip, uppercut, hook
//AllCombos.CombosDefence.c_lparry_1,   // Left parry, jab
//AllCombos.CombosDefence.c_rparry_1_2_rroll, // Right parry, jab, cross, roll right
AllCombos.CombosDefence.c_lroll,      // Left roll
AllCombos.Combos1p.c_3,               // Lead hook
AllCombos.CombosHMCounter1p.c_rs_2,
AllCombos.CombosAdvice.c_keepmoving, // High guard


//AllCombos.CombosMove.c_keep_moving,   // Keep moving
AllCombos.CombosDefence.c_pull,       // Pull
AllCombos.CombosCounterPuncher.c_p_2_sb,
AllCombos.CombosDefence.c_rroll,
AllCombos.CombosHMCounter1p.c_rr_2,
AllCombos.CombosHMCounter1p.c_lr_3,

AllCombos.CombosDefence.c_lbodyblock,
AllCombos.CombosCounter1p.c_lbb_5,

AllCombos.CombosDefence.c_rbodyblock,
AllCombos.CombosCounter1p.c_rbb_6,


AllCombos.CombosCounterPuncher.c_ls_5_2,

AllCombos.CombosDefence.c_lcatch,
AllCombos.CombosCounter1p.c_lc_2,
AllCombos.CombosDefence.c_rcatch,

AllCombos.CombosCounter1p.c_rc_3,


//AllCombos.CombosDefence.c_rcatch_3,   // Right catch, lead hook
//AllCombos.CombosDefence.c_lcatch_2   // Left catch, cross
//AllCombos.CombosMove.c_step_back      // Step back
}, 3);
}
}
public static class FitnessWorkouts
{
public static FitnessWorkoutClass workout2 = new FitnessWorkoutClass(Resources.Languages.objectsStrings.ShadowboxingButton,new List<ComboClass> {AllCombos.CombosExercise.c_shadowboxing, AllCombos.CombosExercise.c_burpees, AllCombos.CombosExercise.c_squats, AllCombos.CombosExercise.c_situps }, 3, 10, 5);

public static class Cardio
{
    public static FitnessWorkoutClass cardio1 = new FitnessWorkoutClass(Resources.Languages.objectsStrings.ShadowboxingButton, new List<ComboClass> { AllCombos.CombosExercise.c_shadowboxing, AllCombos.CombosExercise.c_pushups, AllCombos.CombosExercise.c_shadowboxing, AllCombos.CombosExercise.c_squats, AllCombos.CombosExercise.c_shadowboxing, AllCombos.CombosExercise.c_burpees }, 3, 30, 0);
    public static FitnessWorkoutClass cardio2 = new FitnessWorkoutClass(Resources.Languages.objectsStrings.skippingrope, new List<ComboClass> { AllCombos.CombosExercise.c_skipping_rope, AllCombos.CombosExercise.c_pushups, AllCombos.CombosExercise.c_skipping_rope, AllCombos.CombosExercise.c_squats, AllCombos.CombosExercise.c_skipping_rope, AllCombos.CombosExercise.c_burpees }, 3, 60, 5);
  
}
public static class Core
{
    public static FitnessWorkoutClass core1 = new FitnessWorkoutClass(Resources.Languages.objectsStrings.ShadowboxingButton, new List<ComboClass> { AllCombos.CombosExercise.c_pushups, AllCombos.CombosExercise.c_shadowboxing, AllCombos.CombosExercise.c_squats, AllCombos.CombosExercise.c_shadowboxing, AllCombos.CombosExercise.c_burpees }, 3, 60, 5);
    public static FitnessWorkoutClass core2 = new FitnessWorkoutClass(Resources.Languages.objectsStrings.ShadowboxingButton, new List<ComboClass> { AllCombos.CombosExercise.c_pushups, AllCombos.CombosExercise.c_shadowboxing, AllCombos.CombosExercise.c_squats, AllCombos.CombosExercise.c_shadowboxing, AllCombos.CombosExercise.c_burpees }, 3, 60, 5);

}
public static class Guided
{
    public static FitnessWorkoutClass guidedone = new FitnessWorkoutClass("Freestyle 1", new List<ComboClass> { AllCombos.CombosGuides.movenadjab, AllCombos.CombosGuides.twopunchcombos, AllCombos.CombosGuides.onlystraightpunches, AllCombos.CombosGuides.finishwithbodyshot, AllCombos.CombosGuides.useonlyleadhand, AllCombos.CombosGuides.onlyhooksandupper, AllCombos.CombosGuides.countersonly, AllCombos.CombosGuides.closefighting }, 3, 0, 0);
    public static FitnessWorkoutClass guidedone2 = new FitnessWorkoutClass("Freestyle 2", new List<ComboClass> { AllCombos.CombosGuides.headmovmentandcounter, AllCombos.CombosGuides.startwithjab, AllCombos.CombosGuides.finishwithbodyshot, AllCombos.CombosGuides.movenadjab, AllCombos.CombosGuides.useonlyleadhand, AllCombos.CombosGuides.onlyhooksandupper, AllCombos.CombosGuides.countersonly}, 3, 0, 0);

}


}


}



}


