#!/usr/bin/env python3

import sys
import score
from daytwo import daytwo


def main():
    print(daytwo(sys.argv[1], score.play_to_end))
  
if __name__=="__main__":
    main()