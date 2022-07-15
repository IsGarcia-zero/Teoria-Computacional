import './App.css';
import { Graphviz } from 'graphviz-react';
import * as React from 'react';
function App() {
  return (
    <div className="App">
      <h1>Practica 4 grafo dibujado</h1>
      <Graphviz
        options={
          {
            rankdir: 'LR',
            ranksep: '1',
            nodesep: '1',
            splines: 'polyline',
            overlap: 'false',
            height: 720,
            width: 1280,
            node: {
              shape: 'circle',
              style: 'filled',
              fillcolor: '#006699',
              fontname: 'Arial',
              fontsize: '12',
              fontcolor: 'white',
              margin: '0.1',
              width: '0.5',
              height: '0.5',
            },
            edge: {
              arrowhead: 'open',
              arrowsize: '0.5',
              fontname: 'Arial',
              fontsize: '12',
              fontcolor: 'black',
              color: 'black',
              style: 'solid',
              dir: 'forward',
            }
          }
        }
        dot = {`
        digraph {
          //Para A
          A -> AB[label="w",weight="w"];
          A -> AW[label="e",weight="e"];
          A -> AS[label="p",weight="p"];
          A -> A2[label="s",weight="s"];
          A -> A[label="sigma, r, y, t, i, m, g, a, b",weight="sigma"];
          //Para AB
          AB -> AB[label="w",weight="w"];
          AB -> ACW[label="e",weight="e"];
          AB -> AS[label="p",weight="p"];
          AB -> A2[label="s",weight="s"];
          AB -> A[label="sigma, r, y, t, i, m, g, a, b",weight="sigma"];
          //Para AW
          AW -> AB[label="w",weight="w"];
          AW -> AW[label="e",weight="e"];
          AW -> AY[label="b",weight="b"];
          AW -> AS[label="p",weight="p"];
          AW -> A2[label="s",weight="s"];
          AW -> A[label="sigma, r, y, t, i, m, g, a",weight="sigma"];
          //Para AS
          AS -> AB[label="w",weight="w"];
          AS -> AW[label="e",weight="e"];
          AS -> AS[label="p",weight="p"];
          AS -> AT[label="a",weight="a"];
          AS -> A2[label="s",weight="s"];
          AS -> A[label="sigma, r, y, t, i, m, g, b",weight="sigma"];
          //Para A2
          A2 -> AB[label="w",weight="w"];
          A2 -> AW[label="e",weight="e"];
          A2 -> AS[label="p",weight="p"];
          A2 -> A2[label="s",weight="s"];
          A2 -> A3[label="i",weight="i"];
          A2 -> A[label="sigma, r, y, t, m, g, a, b",weight="sigma"];
          //Para ACW
          ACW -> AB[label="w",weight="w"];
          ACW -> AW[label="e",weight="e"];
          ACW -> ADY[label="b",weight="b"];
          ACW -> AS[label="p",weight="p"];
          ACW -> A2[label="s",weight="s"];
          ACW -> A[label="sigma, r, y, t, i, m, g, a",weight="sigma"];
          //Para AY
          AY -> AB[label="w",weight="w"];
          AY -> AW[label="e",weight="e"];
          AY -> AS[label="p",weight="p"];
          AY -> AZ[label="a",weight="a"];
          AY -> A2[label="s",weight="s"];
          AY -> A[label="sigma, r, y, t, i, m, g, b",weight="sigma"];
          //Para AT
          AT -> AB[label="w",weight="w"];
          AT -> AW[label="e",weight="e"];
          AT -> AS[label="p",weight="p"];
          AT -> AU[label="g",weight="g"];
          AT -> A2[label="s",weight="s"];
          AT -> A[label="sigma, r, y, t, i, m, a, b",weight="sigma"];
          //Para A3
          A3 -> AB[label="w",weight="w"];
          A3 -> AW[label="e",weight="e"];
          A3 -> AS[label="p",weight="p"];
          A3 -> A2[label="s",weight="s"];
          A3 -> A4[label="t",weight="t"];
          A3 -> A[label="sigma, r, y, i, m, g, b",weight="sigma"];
          //Para ADY
          ADY -> AB[label="w",weight="w"];
          ADY -> AW[label="e",weight="e"];
          ADY -> AS[label="p",weight="p"];
          ADY -> AZ[label="a",weight="a"];
          ADY -> AI[label="m",weight="m"];
          ADY -> A2[label="s",weight="s"];
          ADY -> A[label="sigma, r, y, t, i, g, b",weight="sigma"];
          //Para AZ
          AZ -> AB[label="w",weight="w"];
          AZ -> AW[label="e",weight="e"];
          AZ -> A[label="b",weight="b"];
          AZ -> AS[label="p",weight="p"];
          AZ -> A2[label="s",weight="s"];
          AZ -> A1[label="y",weight="y"];
          AZ -> A[label="sigma, r, t, i, m, g, s, b",weight="sigma"];
          //Para AU
          AU -> AB[label="w",weight="w"];
          AU -> AWV[label="e",weight="e"];
          AU -> AS[label="p",weight="p"];
          AU -> A2[label="s",weight="s"];
          AU -> A[label="sigma, r, y, t, i, m, g, s, b",weight="sigma"];
          //Para A4
          A4 -> AB[label="w",weight="w"];
          A4 -> AW5[label="e",weight="e"];
          A4 -> AS[label="p",weight="p"];
          A4 -> A2[label="s",weight="s"];
          A4 -> A[label="sigma, r, y, t, i, m, g, a, b",weight="sigma"];
          //Para AI
          AI -> AB[label="w",weight="w"];
          AI -> AW[label="e",weight="e"];
          AI -> AS[label="p",weight="p"];
          AI -> AJ[label="a",weight="a"];
          AI -> A2[label="s",weight="s"];
          AI -> A[label="sigma, r, y, t, i, m, g, b",weight="sigma"];
          //Para A1
          A1 -> AB[label="w",weight="w"];
          A1 -> AW[label="e",weight="e"];
          A1 -> AS[label="p",weight="p"];
          A1 -> A2[label="s",weight="s"];
          A1 -> A[label="sigma, r, y, t, i, m, g, s, b",weight="sigma"];
          //Para AWV
          AWV -> AB[label="w",weight="w"];
          AWV -> AW[label="e",weight="e"];
          AWV -> AY[label="b",weight="b"];
          AWV -> AS[label="p",weight="p"];
          AWV -> A2[label="s",weight="s"];
          AWV -> A[label="sigma, r, y, t, i, m, g, a",weight="sigma"];
          //Para AW5
          AW5 -> AB[label="w",weight="w"];
          AW5 -> AW[label="e",weight="e"];
          AW5 -> AY[label="b",weight="b"];
          AW5 -> AS[label="p",weight="p"];
          AW5 -> A2[label="s",weight="s"];
          AW5 -> A[label="sigma, r, y, t, i, m, g, a",weight="sigma"];
          //Para AJ
          AJ -> AB[label="w",weight="w"];
          AJ -> AW[label="e",weight="e"];
          AJ -> AS[label="p",weight="p"];
          AJ -> A2K[label="s",weight="s"];
          AJ -> A[label="sigma, r, y, t, i, m, g, a, b",weight="sigma"];
          //Para A2K
          A2K -> AB[label="w",weight="w"];
          A2K -> AW[label="e",weight="e"];
          A2K -> AS[label="p",weight="p"];
          A2K -> A2[label="s",weight="s"];
          A2K -> A3[label="t",weight="t"];
          A2K -> AL[label="y",weight="y"];
          A2K -> A[label="sigma, r, i, m, g, a, b",weight="sigma"];
          //Para AL
          AL -> AB[label="w",weight="w"];
          AL -> AWM[label="e",weight="e"];
          AL -> AS[label="p",weight="p"];
          AL -> AZ[label="a",weight="a"];
          AL -> A2[label="s",weight="s"];
          AL -> A[label="sigma, r, y, t, i, m, g, b",weight="sigma"];
          //Para AWM
          AWM -> AB[label="w",weight="w"];
          AWM -> AW[label="e",weight="e"];
          AWM -> AY[label="b",weight="b"];
          AWM -> AS[label="p",weight="p"];
          AWM -> A2[label="s",weight="s"];
          AWM -> AN[label="r",weight="r"];
          AWM -> A[label="sigma, y, t, i, m, g, a",weight="sigma"];
          //Para AN
          AN -> AB[label="w",weight="w"];
          AN -> AWM[label="e",weight="e"];
          AN -> AS[label="p",weight="p"];
          AN -> A2[label="s",weight="s"];
          AN -> A[label="sigma, r, y, t, i, m, g, a, b",weight="sigma"];
      }`} />

    </div>
  );
}

export default App;
