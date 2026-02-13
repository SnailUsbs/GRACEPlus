# GRACEPlus
A Bombrush mod that adds extra QoL features to GRaces/Graffiti Races

Thunderstore Page: https://thunderstore.io/c/bomb-rush-cyberfunk/p/SnailUSB/GRACEPLUS/

# COMMANDS:

- */GraceHelp :* - Give you a guide in the in game chat showing you each command, and what they do.

- */MapStats :* - If you have/had Map stat tracking enabled, this command will show you your avg win time, best win time, total games played, and total multiplayer games won.
- */GraceStats :* - Will show you your grace stats from ACN, alongside custom stats recorded by GRACEPlus.
- */ShowBest :* - Will show your best win time for the map you are currently in.
- */AvgTime :* - If you have/had Map stat tracking enabled, it will show your avg win time for the map you are currently in.

- */TimeClear :* - will clear your best time for the map you are currently in.
- */TimeClearAll:* - will clear your best time for every map that has one saved.
- */ClearMapStats* : Will clear all map stats for the map you are currently in *other than your best time.*
- */ClearMapStatsAll* : Will clear all map stats for all maps *other than your best times.*
- */GraceStatsClear* : Will clear your general, non map specific stats from GRACEPlus that you see in the /GraceStats command

# Main Features:
- **GRACE Time tracker:** You will get a message in chat telling you how long each GRACE round was, and if it beat your best time, automatically each time a round ends.

- **Best time per map tracking system:** Your best times will be saved in a txt file, inside of the mod folder. They can be cleared all at once with */timeclearall* or you can clear the time of the map you are in by using */timeclear*.

- **Average Win Time Per Map:** If you enable Map Stat Tracking in the config file, you will be able to see your avg win time for the map you are currently on (between solo + pvp games) . Disable it when you dont want your games saved to your map stats, and you can view the avg time any map by using the */AvgTime* command, alongside it also showing up in */MapStats*.

- **Map Based Stats:** You can now track wins, total games played, and **your avg win time** for each map. *While you can see your best time in map stats, you have to delete them separately.*  The stats can be viewed in game using the */MapStats* command, alongside being able to enable, and disable from the config file, allowing you to skip adding certain games to your stats.

- **GRACE Stats:** By using the */gracestats* command you can see your GRACE stats, including you win ratio. This will show you custom stats GRACEPlus recorded, and acn stats. Custom Stats are saved to a text file inside of the mod folder.

- **Custom Chat Messages:** You can now customize most of the messages that get sent chat. Including what gets sent, what variables are sent, etc. The only ones you cant change are the ones from commands. 

- **GRace UI Control:** You can control what appears during a race UI wise, and their color as well.

- **Save ALL Match Results To A Text File:** This is an option that has to be enabled in the config, but when it is enabled it will save every grace match result to a text file in the mod folder with a time stamp, if you won or lost, the type of grace gamemode, and of course the time it took for the round to end

## Extra Features
- **Get a chat message when you get an invite**

# Future Features:
- **Map database:** This will take the ids for maps you currently see, and give them a name from the database. This will allow you to change the names of maps yourself, allow you to add your own custom maps, and allow me to easily add new maps to the mod in the future.
- /revertbest command, which will revert your best time on a map to its previous best time
- Track your wins per map/play session
- reset props at the start of each round
- hideout rail spawn block
- True private lobbies
- layout tracker 
- Ghost player that replays your best time on a given stage

# Last Major Update (v1.3.0) Change log:

The following features can all be turned on/off in the config file.

- **Change The Name Of A Lobby (Client Side Only):** Instead of it just saying "Graffiti Race" at the top of your lobbies, you can now have it say what ever you want, alongside being able to change the color of it.

- **Custom GRace UI Colors:** You can now change the color of the score counter, the count down timer, and the score text in the lobby UI.

- **Control What UI You See During A Race:** You can now control if the mini map, lobby UI, chat, and score counter can be seen while you are in the middle of a race. If you hide any of them, they will become visible again as soon as the race ends.

- The change log file will now hold all change logs moving forward
- Toggle option to start making a log of what happens in your game, which you can send to me if you have any issues with the mod.

# HOW TO BUILD:
- While the source code is all here, you will need to get the required DLLs for it yourself
