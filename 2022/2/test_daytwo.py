from daytwo import daytwo
import score

rounds = """A Y
B X
C Z"""

def test_fruit_salad():
    assert daytwo(rounds, score.play_for_response) == 15


def test_fruit_salad():
    assert daytwo(rounds, score.play_to_end) == 12