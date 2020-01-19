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

        [TestMethod]
        public void Place_Cooled_Container()
        {
            Dock dock = new Dock();
            dock.containers.Add(new Container(Cargo.Cooled, 50000));
            dock.PlaceContainersOnShip(5,5);
            Stack stack = dock.ship.rows[4].stacks[0];
            Assert.AreEqual(1, stack.containers.Count);
        }

        [TestMethod]
        public void Place_Cooled_Containers()
        {
            Dock dock = new Dock();
            for (int i = 0; i < 4; i++)
            {
                dock.containers.Add(new Container(Cargo.Cooled, 50000));
            }
            dock.PlaceContainersOnShip(5, 5);
            Stack stack1 = dock.ship.rows[4].stacks[0];
            Stack stack2 = dock.ship.rows[4].stacks[1];
            Stack stack3 = dock.ship.rows[4].stacks[2];
            Stack stack4 = dock.ship.rows[4].stacks[3];
            Assert.AreEqual(1, stack1.containers.Count);
            Assert.AreEqual(1, stack2.containers.Count);
            Assert.AreEqual(1, stack3.containers.Count);
            Assert.AreEqual(1, stack4.containers.Count);
        
        }

        public List<Container> TestCase()
        {
            List<Container> containers = new List<Container>();
            for (int i = 0; i < 20; i++)
            {
                containers.Add(new Container(Cargo.Normal, 50000));
            }
            containers.Add(new Container(Cargo.Valuable, 50000));
            return containers;
        }

        [TestMethod]
        public void Check_Valuable_Container()
        {
            Dock dock = new Dock();
            dock.containers = TestCase();
            dock.PlaceContainersOnShip(4,3);
            Cargo cargo = dock.ship.rows[2].stacks[3].containers.Last().Cargo;
            Assert.AreEqual(cargo, Cargo.Valuable);
        }
    }
}
