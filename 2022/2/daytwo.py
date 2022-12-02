from score import score
from rock_paper_scissors import play

opponent_hand = {
  "A": "R",
  "B": "P",
  "C": "S"
}

player_hand = {
    "X": "R",
    "Y": "P",
    "Z": "S"
}

play_score = {
  "R": 1,
  "P": 2,
  "S": 3
}

def daytwo(rounds, strategy):
    total = 0
    for round in rounds.splitlines():
        opponent, player = round.split(' ')

        chosen_play = strategy(player, opponent_hand[opponent])
        
        player_wins = play(chosen_play, opponent_hand[opponent])
        
        total += play_score[chosen_play] + score(player_wins);

    return total;
