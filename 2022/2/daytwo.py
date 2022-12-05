from score import score
from rock_paper_scissors import play

opponent_hand = {
  "A": "R",
  "B": "P",
  "C": "S"
}

play_score = {
  "R": 1,
  "P": 2,
  "S": 3
}

def play_round(round, strategy):
    opponent, player = round.split(' ')
    
    chosen_play = strategy(player, opponent_hand[opponent])
    
    player_wins = play(chosen_play, opponent_hand[opponent])
        
    return play_score[chosen_play] + score(player_wins);

def daytwo(rounds, strategy):
    return sum([play_round(x, strategy) for x in rounds.splitlines()])
