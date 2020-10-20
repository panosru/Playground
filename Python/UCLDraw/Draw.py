# Data
import random

pots = [
    # Pot 1
    [
        {"Team": "Liverpool", "Association": "ENG"},
        {"Team": "Chelsea", "Association": "ENG"},
        {"Team": "Barcelona", "Association": "ESP"},
        {"Team": "Manchester City", "Association": "ENG"},
        {"Team": "Juventus", "Association": "ITA"},
        {"Team": "Bayern", "Association": "GER"},
        {"Team": "Paris", "Association": "FRA"},
        {"Team": "Zenit", "Association": "RUS"}
    ],

    # Pot 2
    [
        {"Team": "Real Madrid", "Association": "ESP"},
        {"Team": "Atletico Madrid", "Association": "ESP"},
        {"Team": "Dortmund", "Association": "GER"},
        {"Team": "Napoli", "Association": "ITA"},
        {"Team": "Shakhtar", "Association": "UKR"},
        {"Team": "Tottenham", "Association": "ENG"},
        {"Team": "Ajax", "Association": "NED"},
        {"Team": "Benfica", "Association": "POR"}
    ],

    # Pot 3
    [
        {"Team": "Lyon", "Association": "FRA"},
        {"Team": "Leverkusen", "Association": "GER"},
        {"Team": "Salzburg", "Association": "AUT"},
        {"Team": "Olympiacos", "Association": "GRE"},
        {"Team": "Club Brugge", "Association": "BEL"},
        {"Team": "Valencia", "Association": "ESP"},
        {"Team": "Inter", "Association": "ITA"},
        {"Team": "Dinamo Zagreb", "Association": "CRO"}
    ],

    # Pot 4
    [
        {"Team": "Lokomotiv Moskva", "Association": "RUS"},
        {"Team": "Genk", "Association": "BEL"},
        {"Team": "Galatasaray", "Association": "TUR"},
        {"Team": "RB Leipzig", "Association": "GER"},
        {"Team": "Slavia Praha", "Association": "CZE"},
        {"Team": "Atalanta", "Association": "ITA"},
        {"Team": "Lille", "Association": "FRA"},
        {"Team": "Red Star", "Association": "SRB"}
    ]
]

# Groups
groups = [[]]

# Create 8 group places
for i in range(7):
    groups = [[], *groups]

# Iterate through groups
for num, group in enumerate(groups, start=1):
    print("Building Group {}".format(num))
    while True:
        # Get a random team from each pot
        for j, pot in enumerate(pots):
            team_selected = False
            while not team_selected:
                team = random.choice(pot)
                # if the group is empty, then add the team into the group
                if 0 == len(group):
                    print("Adding team: {}".format(team))
                    group.append(team)
                    # remove from pot once added to group
                    pots[j].remove(team)
                    team_selected = True
                else:
                    # if is not, then check if the group has a team with same association
                    if not any(t['Association'] == team['Association'] for t in group):
                        print("Adding team: {}".format(team))
                        # if it isn't then add to group
                        group.append(team)
                        # remove from pot once added to group
                        pots[j].remove(team)
                        team_selected = True
                    else:
                        pass

        # Run group loop until group is full
        if 4 == len(group):
            break

print("\nResults:")
for i, group in enumerate(groups, start=1):
    print("Group {}".format(i))
    for team in group:
        print(team)
    print("\n")
