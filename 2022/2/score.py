def play_for_response(hand, opponent):
    player_hand = {
        "X": "R",
        "Y": "P",
        "Z": "S"
        }

    return player_hand[hand]

losing_hand = {
        "R": "S",
        "P": "R",
        "S": "P"
    }

wining_hand = {
        "R": "P",
        "P": "S",
        "S": "R"
    }

def play_to_end(hand, opponent):
    match hand:
        case "X": # lose
            return losing_hand[opponent]
        case "Z": # win
            return wining_hand[opponent]
        case _: # draw
            return opponent

def score(player_wins):

    if ( player_wins is None):
        return 3
    else:
        return 6 if player_wins else 0