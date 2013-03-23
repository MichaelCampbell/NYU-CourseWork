/*
 Program:Plot.cpp
 Author:Michael Campbell
 Date: 11/1/10
 Synopsis:Match singular subject with singular verb
 Email: Camp.Mich@yahoo.com
 ________________________________________________________________
 "The Official Movie Plot Generator" by Jason and Justin Heimberg
 http://www.movieplotgenerator.com/
 */

#include <iostream>
#include <cstdlib>	//for srand, rand, RAND_MAX
#include <ctime>	//for time
#include <string>
using namespace std;

struct subject {
	size_t single;
	string line;
};

int main()
{
	/*
	 Although the three arrays just happen to have the same number of
	 elements, they are not parallel arrays.
	 */
	
	cout << "\n";
	
	const subject lines[] = {
		{0, "A cop who doesn't play by the rules"},
		{1, "A group of cops who don't play by the rules"},
		{0, "A single mom"},
		{1, "A group of single mothers"},
		{0, "A naughty nurse"},
		{1, "Three naughty nurses"},
		{0, "An adorable panda cub"},
		{1, "A group of adorable panda cubs"},
		{0, "A ruthless Mafia kingpin"},
		{1, "A ruthless group of Mafia kingpins"},
		{0, "An ancient and powerful wizard"},
		{0, "A brother of a fraternity of lovable slobs, misfits, and drunks"},
		{1, "A fraternity of lovable slobs, misfits, and drunks"},
		{0, "Adolph Hitler"},
		{1, "A groupd of Adolph Hitler reenactors"},
		{0, "From a land where honor and tradition reign, comes the legend of a Samurai who"},
		{1, "From a land where honor and tradition reign, comes the legend of a group of Samurai who"},
		{0, "A bumbling nerd"},
		{1, "A group of bumbling nerds"},	
		{0, "Bigfoot"},
		{1, "A group of mythical creatures"},
		{0, "A crackhead"},
		{1, "A group of crackheads"},
		{0, "A flamboyantly gay hairdresser"},
		{1, "A group of dangerous gay hairdressers"},
		{0, "A retarded boy"},
		{1, "A school of retarded children"},
		{0, "The handicapped cousin of one of America's founding fathers,"},
		{1, "America's founding fathers"},
		{0, "A hockey mask-wearing psychopath"},
		{1, "A group of hockey players, dressed in drag,"},
		{0, "A gangsta rapper"},
		{1,	"A nerd pop group posse"},
		{0, "An unrefined but precocious orphan girl"},
		{1, "An unrefined but precocious group of orphans"},
		{0, "The ultimate crime-fighting indestructible cyborg"},
		{1, "The ultimate crime-fighting indestructible cyborg army"},
		{0, "Elmo from Sesame Street"},
		{1, "The Sesame Street puppets"},
		{0, "A small-town girl with big-time dreams"},
		{1, "A group of small-town girls with big-time dreams"},
		{0, "An orthodox rabbi"},
		{1, "A group of orthodox rabbis"},
		{0, "A burned-out hippie"},
		{1, "A group of nazis"},
		{0, "A Catholic priest"},
		{1, "A group of Catholic priests"},
		{0, "A hooker with a heart of gold"},
		{1, "A hooker and a pimp"},
		{0, "A grumpy midget"},
		{1, "A grumpy midget posse"},
		{0, "A cantankerous senior citizen"},
		{1, "A group of cantankerous senior citizens"},
		{0, "Jesus"},
		{1, "Jesus and the devil"},
		{0, "A no-nonsense Army drill sergeant"},
		{1, "A no-nonsense Army drill sergeant and his squad"},
		{0, "A macho NFL quarterback"},
		{1, "A macho NFL quarterback and his preteen daughter"}
	};
	const size_t nsubject = sizeof lines / sizeof lines[0];
	
	const string predicate[][2] = {
		{"fights crime", "fight crime"},
		{"raises a baby", "raise a baby"},
		{"discovers the wonders of self pleasure", "discover the wonders of self pleasure"},
		{"befriends the creatures of the forest", "befriend the creatures of the forest"},
		{"is on the run from the Mob", "are on the run from the Mob"},
		{"quests for a dragon's treasure", "quest for a dragon's treasure"},
		{"indulges in beer bashes, toga parties, and an assortment of ill-advised high junks", "indulge in beer bashes, toga parties, and an assortment of ill-advised high junks"},
		{"invades Poland", "invade Poland"},
		{"takes on an army of evil Ninjas", "take on an army of evil Ninjas"},
		{"becomes immersed in hip-hop culture", "become immersed in hip-hop culture"},
		{"becomes a nanny for a conservative aristocratic family", "become nannies for a conservative aristocratic family"},
		{"coaches a hapless Little League baseball team", "coach a hapless Little League baseball team"},
		{"hits the Karaoke circuit", "hit the Karaoke circuit"},
		{"grows 50 times in size and goes on a destructive rampage", "grow 50 times in size and go on a destructive rampage"},
		{"travels through time", "travel through time"},
		{"hacks up coeds with a rusty machete", "hack up coeds with a rusty machete"},
		{"becomes a pimp", "become pimps"},
		{"challenges the social mores of upper class society", "challenge the social mores of upper class society"},
		{"commands a fleet of starships against a horde of insectoid aliens", "command a fleet of starships against a horde of insectoid aliens"},
		{"helps children learn to read", "help children learn to read"},
		{"gets transformed into a gorgeous sexpot", "get transformed into gorgeous sexpots"},
		{"competes in gritty inner-city street basketball tournaments", "compete in gritty inner-city street basketball tournaments"},
		{"goes on an LSD-induced psychedelic adventure", "go on an LSD-induced psychedelic adventure"},
		{"discovers a hidden talent for dance", "discover a hidden talent for dance"},
		{"struggles to get off heroin", "struggle to get off heroin"},
		{"tries to lose (his/her) virginity", "try to lose their virginity"},
		{"battles problem flatulence", "battle problem flatulence"},
		{"rises from the grave", "rise from the grave"},
		{"rescues a group of American P.O.W.'s", "rescue a group of American P.O.W.'s"},
		{"comes out of the closet", "come out of the closet"}
	};
	const size_t npredicate = sizeof predicate / sizeof predicate[1][0];
	
	const string modifier[] = {
		"with a mischievous orangutan",
		"while juggling work, parenthood, "
		"and finding personal fulfillment",
		"in two hours of the raunchiest hardcore porno action "
		"ever seen",
		"in this heartwarming animated adventure",
		"in the heart of the Amish country",
		"with a cunning elf, an obese ogre, and a belligerent dwarf",
		"despite being admonished by a crusty old dean",
		"in this documentary narrated by James Earl Jones",
		"in an action-packed epic filled with elaborate, "
		"acrobatic Kung-Fu fight sequences",
		"to win the heard of the high school dreamboat",
		"in the feel-good comedy of the year",
		"in order to pay off a gambling debt",
		"in a beat-up Buick",
		"in the middle of Downtown Tokyo "
		"(in Japanese with English subtitles)",
		"with a wise-cracking robot",
		"in a blood-filled teen slasher",
		"deep in the Compton ghetto",	//Los Angeles
		"in 1954 Baltimore "
		"(based on the Pulitzer Prize winning novel)",
		"shown in spectacular 3-D Imax",
		"in this powerful after school special",
		"set to an all-star '80's soundtrack "
		"featuring Air Supply, Journey, and Survivor",
		"to save the local synagogue",
		"with a magical talking bong, ",
		"in this stoner cult classic",
		"in a rousing adaptation of the Broadway musical",
		"with the help of former tennis great Ivan Lendl "
		"(based on a true story)",
		"with the help of the ghost of Elvis",
		"set against the backdrop "
		"of a Florida retirement community",
		"in the inspiring story loosely adapted from the Bible",
		"in a Vietnamese prison camp",
		"and in the process "
		"learn(s) the true meaning of Christmas"
	};
	const size_t nmodifier = sizeof modifier / sizeof modifier[0];
	
	srand(static_cast<unsigned>(time(0)));
	
	subject sub_output = lines[rand() % nsubject];
	
	cout << sub_output.line << "\n";
	
	if (sub_output.single == 0) {
		cout << predicate[rand() % npredicate][0] << "\n";
	}
	else {
		cout << predicate[rand() % npredicate][1] << "\n";
	}
	
	cout << modifier[rand() % nmodifier] << "\n";
	
	return EXIT_SUCCESS;
}