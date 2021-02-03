﻿using SimpleMusicStore.Models.Enums;
using SimpleMusicStore.Models.MusicalInstruments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleMusicStore.Models.Services
{
    public static class DbInitializeService
    {
        public static void Initialize(MusicStoreContext context)
        {
            if (!context.Firms.Any())
            {
                context.Firms.AddRange(
                    new Firm
                    {
                        Title = "Ibanez",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur purus risus, dictum ac rutrum ut, ultricies id tellus. Morbi a tincidunt lectus, at placerat massa. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc finibus mauris id ante condimentum, vitae ullamcorper nulla lobortis. Nullam eu gravida est, a porta dui. Ut feugiat sapien libero, a sodales sapien egestas in. Vivamus ac est eu nibh placerat rutrum. Nulla metus est, pretium et ultricies at, dignissim eu nulla.",
                        MusicalInstruments = new List<Product>
                        {
                            new ElectricGuitar
                            {
                                Cost = 5499m,
                                Title = "Electric Guitar Ibanez",
                                Description = "Phasellus tristique nisi tortor, id commodo velit auctor ac. Aenean mollis euismod mauris. Sed scelerisque ex vel egestas consectetur. Nullam viverra sed orci at blandit. Duis malesuada justo eget mi convallis, ac lobortis eros facilisis. Morbi hendrerit venenatis eleifend.",
                                Type = ElectricGuitarType.SolidBody
                            },
                            new AcousticGuitar
                            {
                                Cost = 3499m,
                                Title = "Acoustic Guitar Ibanez",
                                Description = "Mauris vestibulum eu dolor sit amet semper. Etiam tempus laoreet sapien eget pretium. Donec vitae est lacinia, placerat massa vel, pulvinar elit.",
                                WithPickup = true
                            }
                        }
                        
                    },
                    new Firm
                    {
                        Title = "Fender",
                        Description = "Nullam ut varius felis. Donec vestibulum ornare odio, id laoreet quam dignissim nec. Etiam ultrices, est et pellentesque consectetur, augue metus interdum eros, varius semper nulla erat non tellus. Sed aliquam eu risus ac varius. Ut suscipit mauris non libero sodales malesuada. Etiam gravida aliquet elit quis tristique. Suspendisse potenti. Proin ipsum mi, elementum sodales gravida rutrum, tempor in ante. Nulla nec tortor ut purus cursus tristique eu vitae nibh. Pellentesque scelerisque at nulla quis ornare. Nulla facilisi. Donec dui ipsum, porta id sagittis quis, rhoncus vitae felis.",
                        MusicalInstruments = new List<Product>
                        {
                            new ElectricGuitar
                            {
                                Cost = 3000m,
                                Title = "Electric Guitar Fender",
                                Description = "Phasellus tristique nisi tortor, id commodo velit auctor ac. Aenean mollis euismod mauris. Sed scelerisque ex vel egestas consectetur. Nullam viverra sed orci at blandit. Duis malesuada justo eget mi convallis, ac lobortis eros facilisis. Morbi hendrerit venenatis eleifend.",
                                Type = ElectricGuitarType.HalfAcoustic
                            },
                            new ElectricGuitar
                            {
                                Cost = 2000m,
                                Title = "Electric Guitar Fender",
                                Description = "Phasellus tristique nisi tortor, id commodo velit auctor ac. Aenean mollis euismod mauris. Sed scelerisque ex vel egestas consectetur. Nullam viverra sed orci at blandit. Duis malesuada justo eget mi convallis, ac lobortis eros facilisis. Morbi hendrerit venenatis eleifend.",
                                Type = ElectricGuitarType.SolidBody
                            }
                        }

                    },
                    new Firm
                    {
                        Title = "Yamaha",
                        Description = "Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Donec vitae imperdiet massa, vitae ultrices tellus. Pellentesque euismod risus massa, id fermentum metus cursus sed. Proin ut fermentum enim. Nunc ornare magna enim, nec dictum est posuere et. Mauris interdum gravida felis quis aliquet. Curabitur urna erat, facilisis at mauris at, eleifend rhoncus ligula. Duis vel pulvinar libero. In varius ut velit gravida scelerisque. In et nisl tristique, tempus libero in, ultricies dolor. Ut finibus justo dignissim, dictum ante et, ornare orci. Maecenas malesuada hendrerit orci eleifend sodales.",
                        MusicalInstruments = new List<Product>
                        {
                            new DigitalPiano
                            {
                                Cost = 8000,
                                Title = "Digital Piano Yamaha",
                                Description = "Mauris vestibulum eu dolor sit amet semper. Etiam tempus laoreet sapien eget pretium. Donec vitae est lacinia, placerat massa vel, pulvinar elit.",
                                Type = DigitalPianoType.Сoncert
                            },
                            new Synthesizer
                            {
                                Cost = 2000,
                                Title = "Synthesizer Yamaha",
                                Description = "Mauris vestibulum eu dolor sit amet semper. Etiam tempus laoreet sapien eget pretium. Donec vitae est lacinia, placerat massa vel, pulvinar elit.",
                                Type = SynthesizerType.Standart
                            },
                            new Drum
                            {
                                Cost = 7000m,
                                Title = "Drum Yamaha",
                                Description = "Mauris vestibulum eu dolor sit amet semper. Etiam tempus laoreet sapien eget pretium. Donec vitae est lacinia, placerat massa vel, pulvinar elit.",
                                Type = DrumType.Electronic
                            }
                            
                        }
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
