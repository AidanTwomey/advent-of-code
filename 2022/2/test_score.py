import pytest

# from rock_paper_scissors import play
from score import play_to_end

class TestClass:

    @pytest.mark.parametrize("hand,opponent,expected", [
        ("X", "S", "P"),
        ("X", "P", "R"),
        ("X", "R", "S"),
        ("Y", "S", "S"),
        ("Y", "P", "P"),
        ("Y", "R", "R"),
        ("Z", "S", "R"),
        ("Z", "P", "S"),
        ("Z", "R", "P")
        ])
    def test_one(self, hand, opponent, expected):
        assert play_to_end(hand, opponent) == expected