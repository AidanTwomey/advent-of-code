import pytest

from rock_paper_scissors import play

class TestClass:

    @pytest.mark.parametrize("hand_one,hand_two,expected", [
        ("R", "S", True),
        ("R", "P", False),
        ("R", "R", None),
        ("P", "S", False),
        ("P", "P", None),
        ("P", "R", True),
        ("S", "S", None),
        ("S", "P", True),
        ("S", "R", False)
        ])
    def test_one(self, hand_one, hand_two, expected):
        assert play(hand_one, hand_two) == expected