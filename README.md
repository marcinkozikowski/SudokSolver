# ...:::  Sudoku Solver .NET CORE :::...

###### Solve any sudoku board (9x9) you wish with Sudoku Solver. Easy as
`var solver = new SudokuSolver()`

`var solvedBoard = solver.Solve(<BOARD_TO_BE_SOLVED>)`

## Example sudko board to solve

<style type="text/css">
.tg  {border-collapse:collapse;border-spacing:0;}
.tg td{font-family:Arial, sans-serif;font-size:14px;padding:10px 5px;border-style:solid;border-width:1px;overflow:hidden;word-break:normal;border-color:black;}
.tg th{font-family:Arial, sans-serif;font-size:14px;font-weight:normal;padding:10px 5px;border-style:solid;border-width:1px;overflow:hidden;word-break:normal;border-color:black;}
.tg .tg-0pky{border-color:inherit;text-align:left;vertical-align:top}
</style>
<table class="tg">
  <tr>
    <th class="tg-0pky">5</th>
    <th class="tg-0pky">3</th>
    <th class="tg-0pky"></th>
    <th class="tg-0pky"></th>
    <th class="tg-0pky">7</th>
    <th class="tg-0pky"></th>
    <th class="tg-0pky"></th>
    <th class="tg-0pky"></th>
    <th class="tg-0pky"></th>
  </tr>
  <tr>
    <td class="tg-0pky">6</td>
    <td class="tg-0pky"></td>
    <td class="tg-0pky"></td>
    <td class="tg-0pky">1</td>
    <td class="tg-0pky">9</td>
    <td class="tg-0pky">5</td>
    <td class="tg-0pky"></td>
    <td class="tg-0pky"></td>
    <td class="tg-0pky"></td>
  </tr>
  <tr>
    <td class="tg-0pky"></td>
    <td class="tg-0pky">9</td>
    <td class="tg-0pky">8</td>
    <td class="tg-0pky"></td>
    <td class="tg-0pky"></td>
    <td class="tg-0pky"></td>
    <td class="tg-0pky"></td>
    <td class="tg-0pky">6</td>
    <td class="tg-0pky"></td>
  </tr>
  <tr>
    <td class="tg-0pky">8</td>
    <td class="tg-0pky"></td>
    <td class="tg-0pky"></td>
    <td class="tg-0pky"></td>
    <td class="tg-0pky">6</td>
    <td class="tg-0pky"></td>
    <td class="tg-0pky"></td>
    <td class="tg-0pky"></td>
    <td class="tg-0pky">3</td>
  </tr>
  <tr>
    <td class="tg-0pky">4</td>
    <td class="tg-0pky"></td>
    <td class="tg-0pky"></td>
    <td class="tg-0pky">8</td>
    <td class="tg-0pky"></td>
    <td class="tg-0pky">3</td>
    <td class="tg-0pky"></td>
    <td class="tg-0pky"></td>
    <td class="tg-0pky">1</td>
  </tr>
  <tr>
    <td class="tg-0pky">7</td>
    <td class="tg-0pky"></td>
    <td class="tg-0pky"></td>
    <td class="tg-0pky"></td>
    <td class="tg-0pky">2</td>
    <td class="tg-0pky"></td>
    <td class="tg-0pky"></td>
    <td class="tg-0pky"></td>
    <td class="tg-0pky">6</td>
  </tr>
  <tr>
    <td class="tg-0pky"></td>
    <td class="tg-0pky">6</td>
    <td class="tg-0pky"></td>
    <td class="tg-0pky"></td>
    <td class="tg-0pky"></td>
    <td class="tg-0pky"></td>
    <td class="tg-0pky">2</td>
    <td class="tg-0pky">8</td>
    <td class="tg-0pky"></td>
  </tr>
  <tr>
    <td class="tg-0pky"></td>
    <td class="tg-0pky"></td>
    <td class="tg-0pky"></td>
    <td class="tg-0pky">4</td>
    <td class="tg-0pky">1</td>
    <td class="tg-0pky">9</td>
    <td class="tg-0pky"></td>
    <td class="tg-0pky"></td>
    <td class="tg-0pky"></td>
  </tr>
  <tr>
    <td class="tg-0pky"></td>
    <td class="tg-0pky"></td>
    <td class="tg-0pky"></td>
    <td class="tg-0pky"></td>
    <td class="tg-0pky">8</td>
    <td class="tg-0pky"></td>
    <td class="tg-0pky"></td>
    <td class="tg-0pky">7</td>
    <td class="tg-0pky">9</td>
  </tr>
</table>

## Solved Sudoku

<style type="text/css">
.tg  {border-collapse:collapse;border-spacing:0;}
.tg td{font-family:Arial, sans-serif;font-size:14px;padding:10px 5px;border-style:solid;border-width:1px;overflow:hidden;word-break:normal;border-color:black;}
.tg th{font-family:Arial, sans-serif;font-size:14px;font-weight:normal;padding:10px 5px;border-style:solid;border-width:1px;overflow:hidden;word-break:normal;border-color:black;}
.tg .tg-c3ow{border-color:inherit;text-align:center;vertical-align:top}
.tg .tg-0pky{border-color:inherit;text-align:left;vertical-align:top}
</style>
<table class="tg">
  <tr>
    <th class="tg-0pky">5</th>
    <th class="tg-0pky">3</th>
    <th class="tg-0pky">4</th>
    <th class="tg-0pky">6</th>
    <th class="tg-0pky">7</th>
    <th class="tg-0pky">8</th>
    <th class="tg-0pky">9</th>
    <th class="tg-0pky">1</th>
    <th class="tg-0pky">2</th>
  </tr>
  <tr>
    <td class="tg-0pky">6</td>
    <td class="tg-0pky">7</td>
    <td class="tg-0pky">2</td>
    <td class="tg-0pky">1</td>
    <td class="tg-0pky">9</td>
    <td class="tg-0pky">5</td>
    <td class="tg-0pky">3</td>
    <td class="tg-0pky">4</td>
    <td class="tg-0pky">8</td>
  </tr>
  <tr>
    <td class="tg-0pky">1</td>
    <td class="tg-0pky">9</td>
    <td class="tg-0pky">8</td>
    <td class="tg-0pky">3</td>
    <td class="tg-0pky">4</td>
    <td class="tg-0pky">2</td>
    <td class="tg-0pky">5</td>
    <td class="tg-0pky">6</td>
    <td class="tg-0pky">7</td>
  </tr>
  <tr>
    <td class="tg-0pky">8</td>
    <td class="tg-0pky">5</td>
    <td class="tg-0pky">9</td>
    <td class="tg-0pky">7</td>
    <td class="tg-0pky">6</td>
    <td class="tg-0pky">1</td>
    <td class="tg-0pky">4</td>
    <td class="tg-0pky">2</td>
    <td class="tg-0pky">3</td>
  </tr>
  <tr>
    <td class="tg-0pky">4</td>
    <td class="tg-0pky">2</td>
    <td class="tg-0pky">6</td>
    <td class="tg-0pky">8</td>
    <td class="tg-0pky">5</td>
    <td class="tg-0pky">3</td>
    <td class="tg-0pky">7</td>
    <td class="tg-0pky">9</td>
    <td class="tg-0pky">1</td>
  </tr>
  <tr>
    <td class="tg-0pky">7</td>
    <td class="tg-0pky">1</td>
    <td class="tg-0pky">3</td>
    <td class="tg-0pky">9</td>
    <td class="tg-0pky">2</td>
    <td class="tg-0pky">4</td>
    <td class="tg-0pky">8</td>
    <td class="tg-0pky">5</td>
    <td class="tg-0pky">6</td>
  </tr>
  <tr>
    <td class="tg-0pky">9</td>
    <td class="tg-0pky">6</td>
    <td class="tg-0pky">1</td>
    <td class="tg-0pky">5</td>
    <td class="tg-0pky">3</td>
    <td class="tg-0pky">7</td>
    <td class="tg-0pky">2</td>
    <td class="tg-0pky">8</td>
    <td class="tg-0pky">4</td>
  </tr>
  <tr>
    <td class="tg-0pky">2</td>
    <td class="tg-0pky">8</td>
    <td class="tg-0pky">7</td>
    <td class="tg-0pky">4</td>
    <td class="tg-0pky">1</td>
    <td class="tg-0pky">9</td>
    <td class="tg-0pky">6</td>
    <td class="tg-0pky">3</td>
    <td class="tg-0pky">5</td>
  </tr>
  <tr>
    <td class="tg-0pky">3</td>
    <td class="tg-0pky">4</td>
    <td class="tg-0pky">5</td>
    <td class="tg-0pky">2</td>
    <td class="tg-0pky">8</td>
    <td class="tg-0pky">6</td>
    <td class="tg-c3ow">1</td>
    <td class="tg-0pky">7</td>
    <td class="tg-0pky">9</td>
  </tr>
</table>

