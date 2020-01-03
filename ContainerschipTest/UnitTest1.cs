using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Containerschip;
using System.Collections.Generic;
using System.Linq;

namespace ContainerschipTest
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void CreateRows_Succeeds()
        {
            Ship ship = new Ship();
            List<Row> expected = new List<Row> { new Row(), new Row(), new Row() };
            ship.Length = 3;
            ship.CreateDeck();
            Assert.AreEqual(expected.Count, ship.rows.Count);
        }

        [TestMethod]
        public void CreateRows_Fails()
        {
            Ship ship = new Ship();
            List<Row> expected = new List<Row> { new Row(), new Row(), new Row() };
            ship.Length = 6;
            ship.CreateDeck();
            Assert.AreNotEqual(expected.Count, ship.rows.Count);
        }

        [TestMethod]
        public void PickLowestStack_Succeeds()
        {
            Row row = new Row();
            row.stacks.Add(new Stack { containers = new List<Container> { new Container(Cargo.Normal, 50000) } });
            row.stacks.Add(new Stack { containers = new List<Container> { new Container(Cargo.Normal, 50000), new Container(Cargo.Cooled, 50000) } });
            row.stacks.Add(new Stack { containers = new List<Container> { new Container(Cargo.Normal, 50000), new Container(Cargo.Normal, 50000), new Container(Cargo.Normal, 50000), } });
            Stack expected = new Stack { containers = new List<Container> { new Container(Cargo.Normal, 50000) } };
            Stack actual = row.PickLowestStackInRow("");
            Assert.AreEqual(expected.containers.Count, actual.containers.Count);
        }

        [TestMethod] 
        public void PickLowestStack_Fails()
        {
            Row row = new Row();
            row.stacks.Add(new Stack { containers = new List<Container> { new Container(Cargo.Normal, 50000) } });
            row.stacks.Add(new Stack { containers = new List<Container> { new Container(Cargo.Normal, 50000), new Container(Cargo.Cooled, 50000) } });
            row.stacks.Add(new Stack { containers = new List<Container> { new Container(Cargo.Normal, 50000), new Container(Cargo.Normal, 50000), new Container(Cargo.Normal, 50000), } });
            Stack expected = new Stack { containers = new List<Container> { new Container(Cargo.Normal, 50000), new Container(Cargo.Cooled, 50000) } };
            Stack actual = row.PickLowestStackInRow("");
            Assert.AreNotEqual(expected.containers.Count, actual.containers.Count);
        }

        [TestMethod]
        public void PickSideWithLeastWeight_Succeeds()
        {
            Ship ship = new Ship(4, 2);
            ship.CreateDeck();
            Row row = ship.rows[0];
            row.stacks[0].containers.Add(new Container(Cargo.Normal, 50000));
            row.stacks[1].containers.Add(new Container(Cargo.Normal, 50000));
            row.stacks[1].containers.Add(new Container(Cargo.Cooled, 50000));
            row.stacks[2].containers.Add(new Container(Cargo.Normal, 50000));
            row.stacks[2].containers.Add(new Container(Cargo.Normal, 50000));
            row.stacks[3].containers.Add(new Container(Cargo.Normal, 70000));
            Row row2 = ship.rows[1];
            row2.stacks[0].containers.Add(new Container(Cargo.Normal, 50000));
            row2.stacks[1].containers.Add(new Container(Cargo.Normal, 50000));
            row2.stacks[1].containers.Add(new Container(Cargo.Cooled, 50000));
            row2.stacks[2].containers.Add(new Container(Cargo.Normal, 50000));
            row2.stacks[2].containers.Add(new Container(Cargo.Normal, 50000));
            row2.stacks[3].containers.Add(new Container(Cargo.Normal, 50000));
            Assert.AreEqual("Left", ship.PickSideWithLeastWeight());
        }

        [TestMethod]
        public void PickSideWithLeastWeight_Fails()
        {
            Ship ship = new Ship(4, 2);
            ship.CreateDeck();
            Row row = ship.rows[0];
            row.stacks[0].containers.Add(new Container(Cargo.Normal, 70000));
            row.stacks[1].containers.Add(new Container(Cargo.Normal, 50000));
            row.stacks[1].containers.Add(new Container(Cargo.Cooled, 50000));
            row.stacks[2].containers.Add(new Container(Cargo.Normal, 50000));
            row.stacks[2].containers.Add(new Container(Cargo.Normal, 50000));
            row.stacks[3].containers.Add(new Container(Cargo.Normal, 50000));
            Row row2 = ship.rows[1];
            row2.stacks[0].containers.Add(new Container(Cargo.Normal, 50000));
            row2.stacks[1].containers.Add(new Container(Cargo.Normal, 50000));
            row2.stacks[1].containers.Add(new Container(Cargo.Cooled, 50000));
            row2.stacks[2].containers.Add(new Container(Cargo.Normal, 50000));
            row2.stacks[2].containers.Add(new Container(Cargo.Normal, 50000));
            row2.stacks[3].containers.Add(new Container(Cargo.Normal, 50000));
            Assert.AreNotEqual("Left", ship.PickSideWithLeastWeight());
        }

        [TestMethod]
        public void PickSideWithLowestWeight_UnevenStacks()
        {
            Ship ship = new Ship(5, 2);
            ship.CreateDeck();
            Row row = ship.rows[0];
            row.stacks.Add(new Stack { containers = new List<Container> { new Container(Cargo.Normal, 50000) } });
            row.stacks.Add(new Stack { containers = new List<Container> { new Container(Cargo.Normal, 50000), new Container(Cargo.Cooled, 50000) } });
            row.stacks.Add(new Stack { containers = new List<Container> { new Container(Cargo.Normal, 50000), new Container(Cargo.Normal, 50000) } });
            row.stacks.Add(new Stack { containers = new List<Container> { new Container(Cargo.Normal, 70000) } });
            row.stacks.Add(new Stack { containers = new List<Container> { new Container(Cargo.Normal, 70000) } });
            Row row2 = ship.rows[1];
            row2.stacks.Add(new Stack { containers = new List<Container> { new Container(Cargo.Normal, 50000) } });
            row2.stacks.Add(new Stack { containers = new List<Container> { new Container(Cargo.Normal, 50000), new Container(Cargo.Cooled, 50000) } });
            row2.stacks.Add(new Stack { containers = new List<Container> { new Container(Cargo.Normal, 50000), new Container(Cargo.Normal, 50000) } });
            row2.stacks.Add(new Stack { containers = new List<Container> { new Container(Cargo.Normal, 50000) } });
            row2.stacks.Add(new Stack { containers = new List<Container> { new Container(Cargo.Normal, 70000) } });
            Assert.AreEqual("Left", ship.PickSideWithLeastWeight());
        }
    }
}
