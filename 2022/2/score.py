def play_for_response(hand, opponent):
    player_hand = {
        "X": "R",
        "Y": "P",
        "Z": "S"
        }

    return player_hand[hand]

def play_to_end(hand, opponent):
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
    if hand == "X": # lose
        end_hand = losing_hand

    if hand == "Y": # draw
        return opponent

    if hand == "Z": # win
        end_hand = wining_hand

    return end_hand[opponent]

def score(player_wins):

    if ( player_wins is None):
        return 3
    else:
        return 6 if player_wins else 0